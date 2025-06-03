﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Results;
using Fcg.Domain.Exceptions.Responses;
using System.Net;

namespace Fcg.WebApi.ApiConfigurations;

public class CustomValidatorResult : IFluentValidationAutoValidationResultFactory
{
    public IActionResult CreateActionResult(ActionExecutingContext context, ValidationProblemDetails? validationProblemDetails)
    {
        return new BadRequestObjectResult(
            new ErrorResponse(
                (int)HttpStatusCode.BadRequest,
                "Erros de validação",
                validationProblemDetails?.Errors ?? new Dictionary<string, string[]>()));
    }
}
