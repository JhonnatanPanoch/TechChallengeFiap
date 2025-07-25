﻿using Microsoft.AspNetCore.Mvc;

namespace Fcg.WebApi.Controllers;


/// <summary>
/// Controller base para as demais controllers da API.
/// Contém configurações comuns e herda de <see cref="ControllerBase"/>.
/// </summary>
[ApiController]
[Produces("application/json")]
[Route("api/v{version:apiVersion}/[controller]")]
public abstract class MainController : ControllerBase
{
}
