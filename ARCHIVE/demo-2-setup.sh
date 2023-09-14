gh workflow disable "MyWebApp - Pull Request Workflow"
gh workflow disable "MyWebApp - Push To Main Workflow"
gh workflow enable "MyWebApp - Pull Request Workflow - Composite Action"
gh workflow enable "Deploy Web App - Reusable Workflow"
gh workflow enable "MyWebApp - Push To Main - Reusable Workflow"
gh workflow list --all
