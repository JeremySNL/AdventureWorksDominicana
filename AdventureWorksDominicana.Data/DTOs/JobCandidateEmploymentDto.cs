using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdventureWorksDominicana.Data.DTOs;

/// <summary>
/// DTO basado en VJobCandidateEmployment (historial laboral)
/// </summary>

public class JobCandidateEmploymentDto
{
    public int JobCandidateId { get; set; }

    public DateTime? EmpStartDate { get; set; }

    public DateTime? EmpEndDate { get; set; }

    [Required(ErrorMessage = "El nombre de la empresa es obligatorio")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre de la empresa debe tener entre 2 y 100 caracteres")]
    public string? EmpOrgName { get; set; }

    [Required(ErrorMessage = "El título del puesto es obligatorio")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El título debe tener entre 2 y 100 caracteres")]
    public string? EmpJobTitle { get; set; }

    public string? EmpResponsibility { get; set; }

    public string? EmpFunctionCategory { get; set; }

    public string? EmpIndustryCategory { get; set; }

    public string? EmpLocCountryRegion { get; set; }

    public string? EmpLocState { get; set; }

    public string? EmpLocCity { get; set; }
}