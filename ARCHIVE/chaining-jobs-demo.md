# Chaining Jobs Demo

[chaining-jobs.yml](https://github.com/mickeygoussetorg/github-actions-presentation/blob/main/.github/workflows/chaining-jobs.yml)

## General Steps

- Open the chaining-jobs.yml and review whats in it.
  - initially all the needs and if statements should be commented out
- Run the workflow. All jobs should run in parallel. You can have up to 20 parallel jobs at once
- Now, let's say we want to execute Job1 => Job2, Job3 => Job4
- Explain the needs statement, uncomment, and run. It should run in this order
- We also want to use this to show conditional statements
- Uncomment/explain the if statement on Job 3, and run the job, setting the parameter to false
  - it will skip job 3, but notice how job 4 also skipped
- Uncomment/explain the if statement on job 4
  - run job with parameter set to false
  - This time job3 skips, but job4 still runs
- You can use needs and if statements to control flow in your workflow files