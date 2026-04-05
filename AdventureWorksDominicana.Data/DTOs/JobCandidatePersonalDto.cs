using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdventureWorksDominicana.Data.DTOs;

/// <summary>
/// DTO basado en VJobCandidate (datos personales)
/// </summary>

public class JobCandidatePersonalDto
{
    public int JobCandidateId { get; set; }

    public int? BusinessEntityId { get; set; }

    [StringLength(30, ErrorMessage = "El prefijo no puede exceder los 30 caracteres")]
    public string? NamePrefix { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 30 caracteres")]
    public string? NameFirst { get; set; }

    [StringLength(30, ErrorMessage = "El segundo nombre no puede exceder los 30 caracteres")]
    public string? NameMiddle { get; set; }

    [Required(ErrorMessage = "El apellido es obligatorio")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "El apellido debe tener entre 2 y 30 caracteres")]
    public string? NameLast { get; set; }

    [StringLength(30, ErrorMessage = "El sufijo no puede exceder los 30 caracteres")]
    public string? NameSuffix { get; set; }

    public string? Skills { get; set; }

    [StringLength(30, ErrorMessage = "El tipo de dirección no puede exceder los 30 caracteres")]
    public string? AddrType { get; set; }

    [StringLength(100, ErrorMessage = "El país no puede exceder los 100 caracteres")]
    public string? AddrLocCountryRegion { get; set; }

    [StringLength(100, ErrorMessage = "El estado no puede exceder los 100 caracteres")]
    public string? AddrLocState { get; set; }

    [StringLength(100, ErrorMessage = "La ciudad no puede exceder los 100 caracteres")]
    public string? AddrLocCity { get; set; }

    [StringLength(20, ErrorMessage = "El código postal no puede exceder los 20 caracteres")]
    public string? AddrPostalCode { get; set; }

    [Required(ErrorMessage = "El correo electrónico es obligatorio")]
    [StringLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres")]
    public string? Email { get; set; }

    [StringLength(100, ErrorMessage = "El sitio web no puede exceder los 100 caracteres")]
    public string? WebSite { get; set; }

    public DateTime ModifiedDate { get; set; }

    // Propiedades calculadas (no requieren DataAnnotations)
    public string Status => BusinessEntityId.HasValue ? "Contratado" : "Pendiente";
    public string FullName => $"{NameFirst} {NameLast}".Trim();
}