MailChimp.NET
=============

.NET Wrapper for the [MailChimp v2.0 API](http://apidocs.mailchimp.com/api/2.0/)

### Quick Start

1. Add a reference to MailChimp.dll, or install the NuGet package (located here https://nuget.org/packages/MailChimp.NET/ )
2. Next, you will need to provide MailChimp.NET with your API key in code.  Need help finding your API key?  Check here: http://kb.mailchimp.com/article/where-can-i-find-my-api-key

In your application, call:

	MailChimpManager mc = new MailChimpManager("YourApiKeyHere-us2");
	ListResult lists = mc.GetLists();

### Examples

##### Getting the first 100 users in each list:

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

##### Subscribe an email address to a list:
	
	MailChimpManager mc = new MailChimpManager("YourApiKeyHere-us2");
    
    //	Create the email parameter
    EmailParameter email = new EmailParameter()
    {
        Email = "customeremail@righthere.com"
    };

    EmailParameter results = mc.Subscribe("YourListID", email);

##### Getting location data for each list:

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


### Status
Here is the progress so far (according to [the MailChimp API docs](http://apidocs.mailchimp.com/api/2.0/#method-sections) ) :

- Campaigns related: **86%** (13 of 15)
- Ecomm related: **0%** (0 of 3)
- Folder related: **100%** (4 of 4)
- List related: **47%** (17 of 36)
- Helper related: **60%** (6 of 10)
- Reports related: **11%** (2 of 18)
- Templates related: **100%** (6 of 6)
- User related: **66%** (4 of 6)
- Vip related: **0%** (0 of 4)

**Overall**: **50%** (52 of 102)
