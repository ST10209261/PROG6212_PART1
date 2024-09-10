using System.Windows;

namespace CMCS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Submit Claim button click event.
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Submitted Successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            txtClaimStatus.Text = "Claim submitted and pending approval.";
        }

        // Upload Documents button click event
        private void UploadDocs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Documents Uploaded Successfully!", "Upload", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Approve Claim button click event
        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Approved.", "Approve", MessageBoxButton.OK, MessageBoxImage.Information);
            txtClaimStatus.Text = "Claim approved.";
        }

        // Reject Claim button click event
        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Rejected.", "Reject", MessageBoxButton.OK, MessageBoxImage.Warning);
            txtClaimStatus.Text = "Claim rejected.";
        }
    }
}
