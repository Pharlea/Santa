﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MinhaLoja.Attributes
{
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(
            ActionExecutingContext context, 
            ActionExecutionDelegate next)
        {
            // Verificação para saber se enviou a chave
            if(!context.HttpContext.Request.Query.
                TryGetValue(Settings.ApiKeyName, out var extractApiKey))
            {
                // Mensagem erro
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "ApiKey não encontrada!"
                };
                return;
            }

            // Verificação se a chave é igual
            if(!Settings.ApiKey.Equals(extractApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 403,
                    Content = "Acesso não autorizado!"
                };
                return;
            }

            await next();
        }
    }
}
