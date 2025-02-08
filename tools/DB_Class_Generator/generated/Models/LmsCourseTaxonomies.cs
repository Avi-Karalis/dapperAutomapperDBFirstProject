using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("lms_course_taxonomies")]
public class LmsCourseTaxonomies : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("course_id")] public string CourseId { get; set; }
    [Column("taxonomy_id")] public string TaxonomyId { get; set; }
    [Column("status")] public int Status { get; set; }

}
