MailChimp.NET
=============

.NET Wrapper for the [MailChimp v2.0 API](http://apidocs.mailchimp.com/api/2.0/)

### Quick Start

Add a reference to MailChimp.dll

Next, you will need to provide MailChimp.NET with your API key.  Need help finding your API key?  Check here: http://kb.mailchimp.com/article/where-can-i-find-my-api-key

In your application, call:

    MailChimp mc = new MailChimp("YourApiKeyHere-us2");
    ListResult lists = mc.GetLists();

### Examples

Getting the first 100 users in each list:

	MailChimp mc = new MailChimp("YourApiKeyHere-us2");
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


### Status
Here is the progress so far (according to [the MailChimp API docs](http://apidocs.mailchimp.com/api/2.0/#method-sections) ) :

- Campaigns related: **0%** (0 of 15)
- Ecomm related: **0%** (0 of 3)
- Folder related: **0%** (0 of 4)
- List related: **19%** (7 of 36)
- Helper related: **50%** (5 of 10)
- Reports related: **0%** (0 of 18)
- Templates related: **0%** (0 of 6)
- User related: **0%** (0 of 6)
- Vip related: **0%** (0 of 4)

**Overall**: **12%** (12 of 102)
