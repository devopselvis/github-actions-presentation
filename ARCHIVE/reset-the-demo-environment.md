# Reset entire demo environment (beginning and end of every presentation)

- Set name of branch protection rule to `main-donotuse`
- Disable the following workflows:
  - `Deploy Web App - Reusable Workflow`
  - `MyWebApp - Pull Request Workflow`
  - `MyWebApp - Pull Request Workflow - Composite Action`
  - `MyWebApp - Push To Main - Reusable Workflow`
  - `MyWebApp - Push To Main Workflow`

- Reset repo to the tag `AddTagHere`

- remove Actions Step Debug variable

## Set Demo Environment for start of Advanced Talk

- Make sure repo is reset to appropriate tag
- Make sure the following workflows are disabled
  - `MyWebApp - Pull Request Workflow`
  - `MyWebApp - Push To Main Workflow`
  - `MyWebApp - Pull Request Workflow - Composite Action`
  - `Deploy Web App - Reusable Workflow`
  - `MyWebApp - Push To Main - Reusable Workflow`
- Set name of branch protection rule to `main`
- Open pages to OIDC configuration in Azure Portal
