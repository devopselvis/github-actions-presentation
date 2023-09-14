# Variables and Context Demo

[variables-and-context.yml](https://github.com/mickeygoussetorg/github-actions-presentation/blob/main/.github/workflows/variables-and-context.yml)

## General Steps

- go back and open the basic workflow, and point out again how we are outputting the parameters
- Open variables-and-context.yml
- Go to job1 and show how we can output the github context object.
- Run the workflow, and review the job1 log, and the github context object
- You can have output variables at both the job and the step level. 
- job2 shows how you can output step variables, and job variables
- job3 consults the output from job 2
- go back to the workflow run and look at job2 and job3 output
- environment variables
  - you can define env variables for all jobs, specific jobs, or specific steps
  - we've defined three workflow level env variables
- in job4, we define two variables with the same name as the workflow level variables, but at the job level
  - and in our step, we do the same thing
  - look at results of previous run. 
  - Var3 has step value, var2 has job value, and job1 has workflow value.