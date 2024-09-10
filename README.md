# PROG6212_PART1

Contract Monthly Claim System (CMCS) Overview:
The Contract Monthly Claim System (CMCS) is a web-based application designed to manage and process contract claims. The system provides a user-friendly interface for submitting claims, uploading supporting documents, and managing claim approvals or rejections.

Features
Dashboard: Overview of active contracts, claims, and payments.
Contract Management: Create, view, and edit contract details.
Claim Submission: Submit new claims, view existing claims, and track claim status.
Payment Processing: Record and track payments related to claims.

Prerequisites
.NET Core 6.0 or later (for running the application)
Visual Studio 2024 or later (for development and debugging)

Installation
Clone the Repository

Copy code
git clone https://github.com/yourusername/cmcs-wpf.git
Open the Project

Launch Visual Studio.
Open the solution file CMCS.sln located in the root of the cloned repository.
Restore Dependencies

In Visual Studio, right-click on the solution in Solution Explorer and select Restore NuGet Packages.
Build and Run
Press F5 or click Start in Visual Studio to build and run the application.

Main Interface:

Submit Claim Button
Function: Allows users to submit a new claim.
Usage: Click this button after filling in the claim details to submit the claim to the system.

Upload Documents Button
Function: Provides functionality for users to upload supporting documents related to the claim.
Usage: Click this button to select and upload files that are necessary for the claim.

Status Box
Function: Displays the current status of the claim.
Initial Message: "No claim submitted."
Usage: The message will update based on the claim submission status or other relevant information.

Approve Claim Button
Function: Used by the Programme Coordinator/Academic Manager to approve a claim.
Usage: Click this button to approve the claim after reviewing it.

Reject Claim Button
Function: Allows the Programme Coordinator/Academic Manager to reject a claim.
Usage: Click this button to reject the claim after evaluation.
Installation and Setup

Usage
Submitting a Claim:

Navigate to the claim submission page.
Fill out the necessary details and click the Submit Claim button.
Uploading Documents:

Click the Upload Documents button and select the files to upload.

Managing Claims:
Programme Coordinators or Academic Managers can view pending claims and use the Approve Claim or Reject Claim buttons to manage them.
