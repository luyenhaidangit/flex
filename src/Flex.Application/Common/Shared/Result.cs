using System.Diagnostics.CodeAnalysis;

namespace Flex.Application.Common.Shared
{
    public class Result
    {
        protected internal Result(bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None)
            {
                throw new InvalidOperationException();
            }

            if (!isSuccess && error == Error.None)
            {
                throw new InvalidOperationException();
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        public bool IsSuccess { get; }

        public bool IsFailure => !IsSuccess;

        public Error Error { get; }

        public static Result Success()
        {
            return new Result(true, Error.None);
        }

        public static Result Failure(Error error)
        {
            return new Result(false, error);
        }

        public static Result<TValue> Success<TValue>(TValue value)
        {
            return new Result<TValue>(value, true, Error.None);
        }

        public static Result<TValue> Failure<TValue>(Error error)
        {
            return new Result<TValue>(default!, false, error);
        }

        public static Result<TValue> Create<TValue>(TValue? value)
        {
            return value is not null ? Success(value) : Failure<TValue>(Error.NullValue);
        }
    }

    public class Result<T> : Result
    {
        private readonly T? _value;

        protected internal Result(T value, bool isSuccess, Error error) : base(isSuccess, error)
        {
            _value = value;
        }

        [NotNull]
        public T Value => IsSuccess ? _value! : throw new InvalidOperationException("The value of a failure result can not be accessed");

        public static implicit operator Result<T>(T? value)
        {
            return Create(value);
        }
    }
}