#include <stdio.h>      /* printf */
#include <assert.h> 
#include <iostream>

using namespace std;
/*Ideas for Twitter Testing

-Test for number of
	-URLS
	-Characters less than, equal to, greater than certain numbers
	-Hashtags
	-Changing colors of text based on Hashtags, URLs, etc
	-Correctness odf date/time of post
	-Containment of special characters - !@?><, etc
	-Contains numbers


*/ 


//need to create working / implemented classes
class Message
{
public:
	double length;   // Length of a message


};


int main(void)
{
	cout << "Enter a twitter message: \n";
	char tmessage;
	cin >> tmessage;
	cout << tmessage;

	system("pause");
}

