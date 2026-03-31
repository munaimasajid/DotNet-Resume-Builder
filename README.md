# DotNet-Resume-Builder

A modern **Resume Builder** application built with **Blazor** and **.NET 8**. Create professional resumes in minutes, choose from multiple templates, and export them as PDFs.

---

## Features

- **Professional Templates**: Classic and Modern resume styles.
- **Easy to Edit**: Fill forms with instant live preview.
- **Achievements Section**: Add multiple achievements, listed automatically.
- **Export to PDF**: Print or save resumes as PDF files.
- **Responsive Design**: Works perfectly on desktop and mobile.
- **Form Validation**: Ensures all required fields are filled properly.

---

## Technologies Used

- **Blazor (InteractiveServer mode)**
- **.NET 8**
- **Bootstrap 5**
- **C# and Razor Components**
- **CSS for styling & PDF-ready print media queries**

---
### Running the Project Locally

1. Clone the repository:
    ```bash
    git clone https://github.com/YOUR_USERNAME/DotNet-Resume-Builder.git
    ```
2. Navigate into the project folder:
    ```bash
    cd DotNet-Resume-Builder
    ```
3. Restore dependencies and run:
    ```bash
    dotnet restore
    dotnet run
    ```
4. Open your browser at the address shown in terminal.

---

## Project Structure

- **Pages/** – Razor pages for Home, Create, Templates, and Preview
- **Services/** – ResumeService for state management
- **Models/** – ResumeModel with validation
- **wwwroot/css/** – Styling for forms, templates, and print-ready resume

---

## How It Works

1. Navigate to **Create Resume** page.
2. Fill in all required fields: Name, Email, Phone, Career Objective, Education, Skills, Experience, Achievements.
3. Select a **template** (Classic or Modern) from the Templates page.
4. Preview your resume on the **Preview** page.
5. Click **Export as PDF** to save or print your resume.

---
