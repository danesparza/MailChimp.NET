MailChimp.NET
=============

.NET Wrapper for the [MailChimp v2.0 API](http://apidocs.mailchimp.com/api/2.0/), built with MailChimp love :heart:

[![Build status](https://ci.appveyor.com/api/projects/status/sltbowtdfnjj79yb)](https://ci.appveyor.com/project/danesparza/mailchimp-net)

### Quick Start

Install the [NuGet package](https://nuget.org/packages/MailChimp.NET/) from the package manager console:

```powershell
Install-Package MailChimp.NET
```
Next, you will need to provide MailChimp.NET with your API key in code.  Need help finding your API key?  Check here: http://kb.mailchimp.com/article/where-can-i-find-my-api-key

In your application, call:

```CSharp
// Pass the API key on the constructor:
MailChimpManager mc = new MailChimpManager("YourApiKeyHere-us2");

// Next, make any API call you'd like:
ListResult lists = mc.GetLists();
```

### Getting help

For help and support, first check out the examples below.  

If you can't figure out what you need from the examples (or if you're running into a tough problem) you might want to check out the [MailChimp support site](http://kb.mailchimp.com/), or ping the [MailChimp API support](https://twitter.com/MailChimp_API) twitter account.  

If you've got a question/bug/feature request for the API wrapper itself, please use [Github issues](https://github.com/danesparza/MailChimp.NET/issues) and consider contributing to the project yourself.  See the "Making contributions" section for more information on how to contribute.  

### Examples

##### Getting the first 100 users in each list:

```CSharp
using MailChimp;
using MailChimp.Lists;
using MailChimp.Helper;

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
// optionally create a class that inherits MergeVar and add any additional merge variable fields:
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

// or use the Dictionary to specify the fields and values. 
// GetMemberInfo will always return the fields and values using the dictionary and not the custom class.
MergeVar myMergeVars = new MergeVar();
myMergeVars.Groupings = new List<Grouping>();
myMergeVars.Groupings.Add(new Grouping());
myMergeVars.Groupings[0].Id = 1234; // replace with your grouping id
myMergeVars.Groupings[0].GroupNames = new List<string>();
myMergeVars.Groupings[0].GroupNames.Add("Your Group Name");
myMergeVars.Add("FNAME", "Testy");
myMergeVars.Add("LNAME", "Testerson");

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

### Mocking
The `IMailChimpManager` and `IMailChimpExportManager` interfaces have been included to allow you to easily mock this API for your own testing.

To set up in your dependency injector, bind the interface with a constructor argument passing your API key. This example uses [Ninject](http://www.ninject.org/) loading the value from an app setting in the Web.config named 'MailChimpApiKey':

```CSharp
kernel.Bind<IMailChimpManager>()
	.To<MailChimpManager>()
	.WithConstructorArgument("apiKey", ConfigurationManager.AppSettings["MailChimpApiKey"]);
```

If you were to use a framework like [Moq](http://github.com/moq/moq4) you might write something like:

```CSharp
public class ThingThatDependsOnMailChimpManager{
	IMailChimpManager _mailChimpManager;

	public ThingThatDependsOnMailChimpManager(IMailChimpManager mailChimpManager){
		_mailChimpManager = mailChimpManager;
	}

	public bool DoSomething(){
		_mailChimpManager.UpdateCampaign("campaignId", "name", new object());
		return true;
	}
}
```
```CSharp
// Arrange
Mock<IMailChimpManager> mailChimpManagerMock = new Mock<IMailChimpManager>();

mailChimpManagerMock.Setup(x => x.UpdateCampaign(It.IsAny<string>, It.IsAny<string>, It.IsAny<object>)
.Return(new CampaignUpdateResult());

// Act
var thing = new ThingThatDependsOnMailChimpManager(mailChimpManagerMock.Object);
var result = thing.DoSomething();

// Assert
Assert.IsTrue(result);
```

### Making contributions
This project is not affiliated with [MailChimp](http://mailchimp.com/about/).  All contributors to this project are unpaid average folks (just like you!) who choose to volunteer their time.  If you like MailChimp and want to contribute, we would appreciate your help!  To get started, just [fork the repo](https://help.github.com/articles/fork-a-repo), make your changes and submit a pull request.   

Also:  If you're reading this and you're from MailChimp, we wouldn't mind [some swag](http://www.wired.com/design/2012/12/mailchimp-swag/).

### Status
Here is the progress so far (according to [the MailChimp API docs](http://apidocs.mailchimp.com/api/2.0/#method-sections) ) :

- [Campaigns](http://apidocs.mailchimp.com/api/2.0/#campaigns-methods) related: **100%** (15 of 15)
- [Ecomm](http://apidocs.mailchimp.com/api/2.0/#ecomm-methods) related: **100%** (3 of 3)
- [Folder](http://apidocs.mailchimp.com/api/2.0/#folders-methods) related: **100%** (4 of 4)
- [Gallery](http://apidocs.mailchimp.com/api/2.0/#gallery-methods) related: **100%** (7 of 7)
- [List](http://apidocs.mailchimp.com/api/2.0/#lists-methods) related: **78%** (32 of 41)
- [Helper](http://apidocs.mailchimp.com/api/2.0/#helper-methods) related: **70%** (7 of 10)
- [Reports](http://apidocs.mailchimp.com/api/2.0/#reports-methods) related: **27%** (5 of 18)
- [Templates](http://apidocs.mailchimp.com/api/2.0/#templates-methods) related: **100%** (6 of 6)
- [User](http://apidocs.mailchimp.com/api/2.0/#users-methods) related: **86%** (6 of 7)
- [Vip](http://apidocs.mailchimp.com/api/2.0/#vip-methods) related: **0%** (0 of 4)
- [Goal](http://apidocs.mailchimp.com/api/2.0/#goal-methods) related **0%** (0 of 2)
- [Conversations](http://apidocs.mailchimp.com/api/2.0/#conversations-methods) related **0%** (0 of 3)

**Overall**: **71%** (85 of 120)

