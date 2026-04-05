using AdventureWorksDominicana.Data.Context;
using AdventureWorksDominicana.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureWorksDominicana.Services;

public class JobCandidateService(IDbContextFactory<Contexto> DbFactory) : IService<JobCandidate, int>
{
    public async Task<bool> Guardar(JobCandidate entidad)
    {
        if (!await Existe(entidad.JobCandidateId))
            return await Insertar(entidad);
        else
            return await Modificar(entidad);
    }

    private async Task<bool> Existe(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.JobCandidates.AnyAsync(j => j.JobCandidateId == id);
    }

    private async Task<bool> Insertar(JobCandidate entidad)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.JobCandidates.Add(entidad);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(JobCandidate entidad)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.JobCandidates.Update(entidad);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<JobCandidate?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.JobCandidates.FirstOrDefaultAsync(j => j.JobCandidateId == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.JobCandidates.Where(j => j.JobCandidateId == id).ExecuteDeleteAsync() > 0;
    }

    public async Task<List<JobCandidate>> GetList(Expression<Func<JobCandidate, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.JobCandidates.Where(criterio).ToListAsync();
    }
}
