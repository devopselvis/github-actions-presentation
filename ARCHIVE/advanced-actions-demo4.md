# Advanced Actions - Demo 4

This demo shows the following topics:

- Debugging Workflows

## General Steps

- Add the `Actions_step_debug` variable and set to true
- Run the `Basic Workflow` workflow, and see all the purple

- ACT
  - echo $PAT | docker login ghcr.io -u mickeygousset --password-stdin
  - github.com/nektos/act
  - Can download and install, or use brew
  - Provides a quick way to validate changes locally, without pushing them to GitHub and running the workflow
  - Uses containers to emulate workflows by building up a docker container to execute the job
  - `act workflow_dispatch -l`
    - Shows me all the jobs that trigger off that
  - `act -j greet`