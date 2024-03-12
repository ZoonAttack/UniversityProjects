# <p style="text-align: center;">Twitter top influencers</p>

The required task is to read from a file with big data. Store that data in a suitable data structure that helps us retrieve top influencers in a decreasing order.

My approach was the following: 
-	Using the unordered map. The reason I chose unordered map was because sorting wasn’t a requirement. As the unordered map is also faster
-	Unordered maps use hashing which helps in storing big data without any problem retrieving it. Lookup was an O (1) process.
-	Make a class called User that Is used to store influencers information (ID and FOLLOWERS count)
-	Then another class that holds the data of the excel sheet.
-	Using two unordered maps. One that stores the Object of the influencer as value and their ID as key. Then another one that stores only the ID as key and a vector of followers that follow that influencer (only storing the followers ID)
-	That way I can access the followers if needed for further modification(as well as debugging ). And the users unordered map was to retrieve the FOLLOWERS identifier in the object of that influencer.
-	Now for the top influencers part. I used a max heap and overloaded the comparison operator, so it compares the FOLLOWERS count in the User(influencer) object
o	bool operator<(const User& other)
o			const { 
o			return followers < other.followers;
o		}
-	When doing that the root of my maxheap is the top influencer so I keep popping that until the heap is empty. Doing that and storing each top influencer in a vector of top influencers then returning that vector to the program to write it into an output file 
This whole process takes O(nlog(n)) 
