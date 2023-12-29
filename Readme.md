<!-- default file list -->
*Files to look at*:

* [Contacts.cs](./CS/WinWebSolution.Module/Contacts.cs) (VB: [Contacts.vb](./VB/WinWebSolution.Module/Contacts.vb))
* [Documents.cs](./CS/WinWebSolution.Module/Documents.cs) (VB: [Documents.vb](./VB/WinWebSolution.Module/Documents.vb))
<!-- default file list end -->
# OBSOLETE - How to set different criteria for a base lookup property in descendant classes

**Overridden properties are unsupported in both XAF & XPO. For more information, see the <a href="https://www.devexpress.com/Support/Center/p/K18270">Can I override properties of business objects?</a> KB Article.**

----------------------

**OLD:**
<p>Imagine we have a base abstract class, which has a lookup property, that should be filtered differently in descendant classes. This example shows how to accomplish this task by using two different approaches:<br />
1. By overriding the base lookup property in a descendant class and applying the DataSourceCriteria attribute with a different criteria (please refer to the <a href="https://www.devexpress.com/Support/Center/p/K18270">Can I override properties of business objects?</a> KB Article for more details);<br />
2. By using the DataSourceProperty attribute that uses a custom lookup data source that is filtered differently in descendant classes (actually, this is  Scenario 4 from the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2681">How to: Filter Lookup List Views</a> help topic).</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/K18270">Can I override properties of business objects?</a></p>

<br/>


