﻿using System;

namespace Rafsan.DataAccess.Repositories.Exceptions;

public class DuplicateTakeException : Exception
{
	private const string message = "Duplicate use of Take(). Ensure you don't use Take() more than once in the same specification!";

	public DuplicateTakeException()
	    : base(message)
	{
	}

	public DuplicateTakeException(Exception innerException)
	    : base(message, innerException)
	{
	}
}