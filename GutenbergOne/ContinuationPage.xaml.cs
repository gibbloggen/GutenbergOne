using Windows.UI.Xaml.Controls;


//This page is straight from Microsoft's UWP Printing Example, only change I think is the namespace, made it the namespace of the project.  And also
//removed the SDKTemplate in the using.  I have not tested multiple pages yet.
namespace GutenbergOne
{
    /// <summary>
    /// A paged used to flow text from a given text container
    /// Usage: Output scenarios 1-4 might not fit entirely on a given "printer page"
    /// In that case simply add new continuation pages of the given size until all the content can be displayed
    /// </summary>
    public sealed partial class ContinuationPage : Page
    {
        /// <summary>
        /// Creates a continuation page and links text-flow to a text flow container
        /// </summary>
        /// <param name="textLinkContainer">Text link container which will flow text into this page</param>
        public ContinuationPage(RichTextBlockOverflow textLinkContainer)
        {
            InitializeComponent();
            textLinkContainer.OverflowContentTarget = ContinuationPageLinkedContainer;
        }
    }
}
