
# SlidelyFormApp

Welcome to SlidelyFormApp, a Windows Forms application designed to manage form submissions efficiently.

## Overview

SlidelyFormApp simplifies form submission management with features like creation, viewing, editing, and deletion of submissions. Users can input details such as Name, Email, Phone Number, GitHub Repository Link, and Stopwatch Time.

## Features

- **Create New Submission**: Submit forms with ease using intuitive input fields.
- **View Submissions**: Navigate through submissions effortlessly.
- **Edit and Delete**: Make changes or remove unwanted submissions conveniently.

## Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- NuGet package manager

## Setup and Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/SlidelyFormApp.git
   cd SlidelyFormApp

2. **Open and Build**:
Open the solution file (SlidelyFormApp.sln) in Visual Studio.
Restore NuGet packages and build the solution.

## Running the Application
1. **Start Backend Server**:
    - Ensure the backend server is running (refer to backend server setup in the backend's README).
2. **Run the Application**:
    - Press F5 or go to Debug -> Start Debugging in Visual Studio.

## API Endpoints

1. POST /submit: Submit a new form.
2. GET /read?index=<index>: Read a specific submission.
3. PUT /edit/<index>: Update a specific submission.
4. DELETE /delete/<index>: Delete a specific submission.
5. GET /search?email=<email>: Search submissions by email.

## Keyboard Shortcuts
1. Ctrl + N: Create New Submission.
2. Ctrl + V: View Submissions.
3. Ctrl + P: Previous Submission.
4. Ctrl + N: Next Submission.
5. Ctrl + T: Toggle Stopwatch.
6. Ctrl + S: Submit Form (Create Form).

## Usage
- **Main Form**: Access Create Submission and View Submissions forms.

- **Create Submission Form**: Fill in details and submit forms.

- **View Submissions Form**: Navigate, edit, and delete submissions.

## Troubleshooting

- No Submissions Found: Ensure the server is running and configured correctly.
- Server Errors: Check server logs for issues and endpoint functionality.
