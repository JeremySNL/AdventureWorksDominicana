using AdventureWorksDominicana.Data.Context;
using AdventureWorksDominicana.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureWorksDominicana.Services;

public class UserService(IDbContextFactory<Contexto> DbFactory) : IService<AspNetUser, int>
{
    public Task<AspNetUser?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<AspNetUser>> GetList(Expression<Func<AspNetUser, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.AspNetUsers.Where(criterio).OrderBy(t => t.UserName).ToListAsync();
    }

    public Task<bool> Guardar(AspNetUser entidad)
    {
        throw new NotImplementedException();
    }
}
