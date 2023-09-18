# Advanced Actions - Demo 2

This demo shows the following topics:

- Composite Actions
- Reusable worfklows


## General Steps

- First, lets enable/disable some workflows
  - from command line, run `./demo-2-setup.sh` to disable workflows from demo 1 and enable the needed workflows for demo 2
- There was a lot of duplicate code
  - Build job in both PR and Push is effectively the ame
  - Deploy jobs are the same, with just some changes, like the environment to target and the app service to deploy to
- We have some options here
  - Custom Actions (specifically a composite action)
  - Reusable workflow

- Composite Action
  - We are going to encapsulate the build job as a composite action. 
  - modify menu to change menu name, and create a PR
  - open `mickeygoussetorg/github-actions-presentation-composite-action` and review action.yml
  - open `mywebapp-pr-with-composite-action.yml` and review calling the composite action
  - point out that because it is just a step, you can add other steps.
  - Merge PR to kick off push to main

- Reusable workflow
  - For push to main, we are using composite action for build, and a reusable workflow for deploy
  - `mywebapp-reusable-workflow-deploy-web-app.yml` and review how it works
  - `mywebapp-push-to-main-with-reusable-workflow.yml` and review how it works
  - Approve prod deploy, and view dev deploy to see that it worked
  