1. When does Git perform a fast-forward and when is a merge commit created
   Git does a fast-forward when only the feature branch has new commits and main has not changed. It just moves main forward without creating an extra commit. A merge commit is created when both main and the feature branch have new commits, so Git needs to combine them and creates a new commit to do that.
2. What is the practical difference between merge and rebase?
   Merge combines two branches and keeps the full history, including a merge commit. You can see in the graph that branches were used. Rebase moves the feature branch commits on top of main, so the history looks straight, like there was never a separate branch.
3. How was the conflict resolved in your repository
   The same line of code was changed differently on main and on feature-conflict. When merging, Git could not decide which version to keep, so it marked it as a conflict. The conflict was resolved by looking at both versions and choosing one that made sense, and making sure the code still worked. Then the merge was completed and pushed.
