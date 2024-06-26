﻿

namespace Application.Common.Models;

public class Result
{
    internal Result(bool succeeded, IEnumerable<string> errors)
    {
        IsSuccess = succeeded;
        Errors = errors.ToArray();
    }

    public bool IsSuccess { get; set; }

    public string[] Errors { get; set; }

    public static Result Success()
    {
        return new Result(true, []);
    }

    public static Result Failure(IEnumerable<string> errors)
    {
        return new Result(false, errors);
    }

    public static Result Failure(string error)
    {
        return new Result(false, [error]);
    }


}