using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdventureWorksDominicana.Data.DTOs;

/// <summary>
/// DTO basado en VJobCandidateEducation (historial académico)
/// </summary>

public class JobCandidateEducationDto
{
    public int JobCandidateId { get; set; }

    public string? EduLevel { get; set; }

    public DateTime? EduStartDate { get; set; }

    public DateTime? EduEndDate { get; set; }

    [Required(ErrorMessage = "El título o grado es obligatorio")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "El título debe tener entre 2 y 50 caracteres")]
    public string? EduDegree { get; set; }

    [StringLength(50, ErrorMessage = "La especialidad no puede exceder los 50 caracteres")]
    public string? EduMajor { get; set; }

    [StringLength(50, ErrorMessage = "La especialidad secundaria no puede exceder los 50 caracteres")]
    public string? EduMinor { get; set; }

    [StringLength(5, ErrorMessage = "El GPA no puede exceder los 5 caracteres")]
    public string? EduGpa { get; set; }

    [StringLength(5, ErrorMessage = "La escala del GPA no puede exceder los 5 caracteres")]
    public string? EduGpascale { get; set; }

    [Required(ErrorMessage = "El nombre de la institución es obligatorio")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "La institución debe tener entre 2 y 100 caracteres")]
    public string? EduSchool { get; set; }

    [StringLength(100, ErrorMessage = "El país no puede exceder los 100 caracteres")]
    public string? EduLocCountryRegion { get; set; }

    [StringLength(100, ErrorMessage = "El estado no puede exceder los 100 caracteres")]
    public string? EduLocState { get; set; }

    [StringLength(100, ErrorMessage = "La ciudad no puede exceder los 100 caracteres")]
    public string? EduLocCity { get; set; }
}