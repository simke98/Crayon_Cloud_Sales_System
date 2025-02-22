﻿namespace Crayon.CSS.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; init; }
    public required DateTime CreatedAt { get; init; }
    public required DateTime UpdatedAt { get; set; }
}
