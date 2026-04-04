using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksDominicana.Data.Models;

/// <summary>
/// Résumés submitted to Human Resources by job applicants.
/// </summary>
[Table("JobCandidate", Schema = "HumanResources")]
public partial class JobCandidate
{
    /// <summary>
    /// Primary key for JobCandidate records.
    /// </summary>
    [Key]
    [Column("JobCandidateID")]
    [Required(ErrorMessage = "El ID del candidato es obligatorio")]
    public int JobCandidateId { get; set; }

    /// <summary>
    /// Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.
    /// </summary>
    [Column("BusinessEntityID")]
    public int? BusinessEntityId { get; set; }

    /// <summary>
    /// Résumé in XML format.
    /// </summary>
    [Column(TypeName = "xml")]
    [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "El currículum debe tener al menos 10 caracteres")]
    public string? Resume { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    [Required(ErrorMessage = "La fecha de modificación es obligatoria")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("BusinessEntityId")]
    [InverseProperty("JobCandidates")]
    public virtual Employee? BusinessEntity { get; set; }
}