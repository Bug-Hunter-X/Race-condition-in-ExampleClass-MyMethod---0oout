# Race Condition in C# ExampleClass.MyMethod()

This repository demonstrates a race condition bug in a simple C# class and its solution.

## Bug Description

The `ExampleClass` has a method `MyMethod()` that checks the value of `MyValue`.  If multiple threads call `MyMethod()` concurrently and modify `MyValue`, it can lead to unexpected results because the check `MyValue == 0` might not reflect the actual value due to the concurrent access.  This is a classic race condition.

## Bug Reproduction

1. Clone this repository.
2. Compile and run the `bug.cs` file.  You will likely see inconsistent or unexpected behavior as threads compete to modify `MyValue`.

## Solution

The solution involves using a locking mechanism (e.g., `lock` statement) to synchronize access to `MyValue`. This ensures that only one thread can access and modify `MyValue` at a time, preventing the race condition. See `bugSolution.cs` for the corrected code.

## Additional Notes

Race conditions are a common source of bugs in multi-threaded applications. Using appropriate synchronization techniques is crucial for writing robust and reliable concurrent code.  The `lock` statement, semaphores, mutexes, and other synchronization primitives are powerful tools to manage concurrency. This example uses the simplest approach suitable for illustrative purposes.