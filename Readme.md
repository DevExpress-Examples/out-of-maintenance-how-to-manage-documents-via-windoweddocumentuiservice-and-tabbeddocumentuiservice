# How to: Manage documents via WindowedDocumentUIService and TabbedDocumentUIService


<p>The WindowedDocumentUIService provides methods to create and show documents as windows.<br /> The TabbedDocumentUIService provides methods to create and show documents as tabs.<br /> The CurrentWindowService provides methods to close the current window.</p>
<p>The following example demonstrates how to use the above services in a View Model.<br /><br />If you wish to perform some actions when the document is about to close or wish to prevent a document from being closed, implement the IDocumentViewModel interface for the view model that represents a document. The IDocumentViewModel.Close method will be called before the document closure.</p>

<br/>


