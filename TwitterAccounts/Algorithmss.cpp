#include <iostream>
#include <fstream>
#include <sstream>
#include <unordered_map>
#include <vector>
#include <queue>
using namespace std;
class User {
public:
	int id;
	int followers;
	User() : id(0), followers(0) {};
	User(int i) : id(i), followers(0) {};
	// To sort in top followers order
	bool operator<(const User& other)
		const {
		return followers < other.followers;
	}
};
class table {
	unordered_map<int, User> users;
	unordered_map<int, vector<int>> influencers;
public:
	void AddFollower(int followerId, int influencerId) // O(1)
	{
		influencers[influencerId].push_back(followerId);
		users[influencerId].followers++;
		users[influencerId].id = influencerId;
	}
	vector<User> Topinfluencer() // O(n + nlogn)
	{
		priority_queue<User> maxHeap;
		for (const auto& pair : users) // O(n)
		{
			maxHeap.push(pair.second);
		}
		vector<User> topinfluencers;
		topinfluencers.reserve(users.size());
		while (!maxHeap.empty())
		{
			topinfluencers.emplace_back(maxHeap.top()); // O(1)
			maxHeap.pop(); //O(logn)
		}
		return topinfluencers;
	}
};
int main() {
	clock_t start, end;
	start = clock();
	table* t = new table();
	ifstream file("twitter.csv");
	ofstream topInfluencersFile("topinfluencers.csv");
	string line;
	while (getline(file, line)) // O(n)
	{
		istringstream piece(line);
		string followerId, influencerId;
		if (getline(piece, followerId, ',') && getline(piece, influencerId, ','))
		{
			int followerIdInt = stoi(followerId);
			int influencerIdInt = stoi(influencerId);
			t->AddFollower(followerIdInt, influencerIdInt);
		}
	}
	vector<User> topinfluencers = t->Topinfluencer(); // O(n + nlogn)
	for (const User& influencer : topinfluencers)  // O(n)
		topInfluencersFile << "User " << influencer.id << ": " << influencer.followers << " followers\n";

	topInfluencersFile.close();
	end = clock();
	double time_taken = (end - start) / double(CLOCKS_PER_SEC);
	cout << "Time taken by program is : "
		<< time_taken << endl;
	cout << " sec " << endl;
}