# Advanced Actions - Demo 1

This demo shows the following topics:

- CI/CD
- Concurrency
- Environments
- Secrets
- GH CLI
- Code Scanning
- Branch Protection Rules
- OIDC with Azure

Use the GH CLI to interact with the repository, show, and run workflows as needed

On PR:

- Link to an issue
- Code Scanning
- Build/Test/Upload Artifacts
- Branch Protection Rules

On Push to main branch:

- Concurrency
- Deploy code using environments
- Secrets
- OIDC with Azure

## General Steps

- Make sure `Star the Repo` workflow is disabled

- Let's start with the GH CLI
  - `gh workflow list` - but I know I have more than that
  - `gh workflow list --help` - I need to use the all command
  - `gh workflow list --all` - ah, I have some workflows disabled (should be 5)
  - `gh workflow enable "MyWebApp - Pull Request Workflow"`
  - `gh workflow enable "MyWebApp - Push To Main Workflow"`
  - Now I have the workflows enabled for demo 1
  - `gh workflow view` and select `MyWebApp - Pull Request Workflow` to see information on the recent runs
  - `gh issue create --title "Advanced Actions - Demo 1" --body "Used with demo 1 of Advanced Actions"` - Create an issue to track our work
  - `gh issue view [issue number]`
  - ok, you've seen some of what we can do from the cli, we will do more later.  Let's go to the repo in the web browser
  - `gh repo view --web`
  - Go to issues tab and show the issue we created

- Let's go create a branch and make a code change and see what happens
  - open `src/mywebapp/Pages/Shared/_Layout.cshtml`
  - Add a new menu option
  - Commit to branch `mickeygousset/add-menu-option`
  - Create the PR, linking to our issue number
    - `This PR resolves #<number>`
  - You can see we have multiple checks that kick off. And some are required and some are not.
  - Let's go look at the workflow and how it works
  - Open the `mywebapp-pr.yml` and explain it
  - PR required check should have failed. investigate it
  - Go make another code change on the branch and comment out the offending code
  - This kicks the PR off again
  - back at command line do a `gh run view` and view it
  - PR passes and I can merge.  When I merge, it is going to kick off a push to main, which will kick off the build/deploy workflow

- Also, notice how the issue was closed when the PR was closed

- Pushing to main
  - show workflow running in gui
  - `gh run watch` to watch it run
  - open the `mywebapp-push-to-main.yml` and explain
  - concurrency - kick off another manually and see what happens. Then cancel it
  - Go to settings and show tne environments
    - secrets - 
    - manual approvals
  - Show how workflow is waiting for manual approval
  - Open DEV deployment
  - Open OIDC configuration and briefly explain why it is a good idea
  - Approve the deployment to prod
  - Go to Code tab in repo and look at Environments
  - Look a CLI tracking the deployment



- Review what all we have covered, then move on to Demo 2.


