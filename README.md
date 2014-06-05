MailChimp.NET
=============

.NET Wrapper for the [MailChimp v2.0 API](http://apidocs.mailchimp.com/api/2.0/), built with MailChimp love :heart:

[![Build status](https://ci.appveyor.com/api/projects/status/sltbowtdfnjj79yb)](https://ci.appveyor.com/project/danesparza/mailchimp-net)

### Quick Start

1. Install the [NuGet package](https://nuget.org/packages/MailChimp.NET/) from the package manager console:

```powershell
Install-Package MailChimp.NET
```
2. Next, you will need to provide MailChimp.NET with your API key in code.  Need help finding your API key?  Check here: http://kb.mailchimp.com/article/where-can-i-find-my-api-key

In your application, call:

```CSharp
// Pass the API key on the constructor:
MailChimpManager mc = new MailChimpManager("YourApiKeyHere-us2");

// Next, make any API call you'd like:
ListResult lists = mc.GetLists();
```

### Examples

##### Getting the first 100 users in each list:

```CSharp
using MailChimp;
using MailChimp.Lists;

MailChimpManager mc = new MailChimpManager("YourApiKeyHere-us2");
ListResult lists = mc.GetLists();

//  For each list
foreach(var list in lists.Data)
{
	//  Write out the list name:
	Debug.WriteLine("Users for the list " + list.Name);
	
	//  Get the first 100 members of each list:
	MembersResult results = mc.GetAllMembersForList(list.Id, "subscribed", 0, 100);
	
	//  Write out each member's email address:
	foreach(var member in results.Data)
	{
	    Debug.WriteLine(member.Email);
	}
}
```

##### Subscribe an email address to a list:

```CSharp
MailChimpManager mc = new MailChimpManager("YourApiKeyHere-us2");

//	Create the email parameter
EmailParameter email = new EmailParameter()
{
	Email = "customeremail@righthere.com"
};

EmailParameter results = mc.Subscribe("YourListID", email);
```

##### Subscribe an email address to a list and set their interest groups (custom merge variables):

```CSharp	
// create a class that inherits MergeVar and add any additional merge variable fields:
[System.Runtime.Serialization.DataContract]
public class MyMergeVar : MergeVar
{
	[System.Runtime.Serialization.DataMember(Name = "FNAME")]
	public string FirstName { get; set; }
	[System.Runtime.Serialization.DataMember(Name = "LNAME")]
	public string LastName { get; set; }
}

MyMergeVar myMergeVars = new MyMergeVar();
myMergeVars.Groupings = new List<Grouping>();
myMergeVars.Groupings.Add(new Grouping());
myMergeVars.Groupings[0].Id = 1234; // replace with your grouping id
myMergeVars.Groupings[0].GroupNames = new List<string>();
myMergeVars.Groupings[0].GroupNames.Add("Your Group Name");
myMergeVars.FirstName = "Testy";
myMergeVars.LastName = "Testerson";

MailChimpManager mc = new MailChimpManager("YourApiKeyHere-us2");

//	Create the email parameter
EmailParameter email = new EmailParameter()
{
	Email = "customeremail@righthere.com"
};

EmailParameter results = mc.Subscribe("YourListID", email, myMergeVars);
```

##### Getting location data for each list:

```CSharp
MailChimpManager mc = new MailChimpManager("YourApiKeyHere-us2");
ListResult lists = mc.GetLists();

//  For each list
foreach(var list in lists.Data)
{
	Debug.WriteLine("Information for " + list.Name);
	
	//  Get the location data for each list:
	List<SubscriberLocation> locations = mc.GetLocationsForList(list.Id);
	
	//  Write out each of the locations:
	foreach(var location in locations)
	{
	    Debug.WriteLine("Country: {0} - {2} users, accounts for {1}% of list subscribers", location.Country, location.Percent, location.Total);
	}
}
```

### Making contributions
This project is not affiliated with [MailChimp](http://mailchimp.com/about/).  All contributors to this project are unpaid average folks (just like you!) who choose to volunteer their time.  If you like MailChimp and want to contribute, we would appreciate your help!  To get started, just [fork the repo](https://help.github.com/articles/fork-a-repo), make your changes and submit a pull request.   

Also:  If you're reading this and you're from MailChimp, we wouldn't mind [some swag](http://www.wired.com/design/2012/12/mailchimp-swag/).

### Status
Here is the progress so far (according to [the MailChimp API docs](http://apidocs.mailchimp.com/api/2.0/#method-sections) ) :

- Campaigns related: **100%** (15 of 15)
- Ecomm related: **0%** (0 of 3)
- Folder related: **100%** (4 of 4)
- List related: **69%** (25 of 36)
- Helper related: **60%** (6 of 10)
- Reports related: **27%** (5 of 18)
- Templates related: **100%** (6 of 6)
- User related: **100%** (6 of 6)
- Vip related: **0%** (0 of 4)

**Overall**: **64%** (66 of 102)
