using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("companies")]
public class Companies : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("code")] public string Code { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("root_id")] public string RootId { get; set; }
    [Column("parent_id")] public string ParentId { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("prefix")] public string Prefix { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("size")] public string Size { get; set; }
    [Column("vat")] public string Vat { get; set; }
    [Column("media_id")] public string MediaId { get; set; }
    [Column("pc_media_id")] public string PcMediaId { get; set; }
    [Column("default_experience_id")] public string DefaultExperienceId { get; set; }
    [Column("stripe_id")] public string StripeId { get; set; }
    [Column("card_brand")] public string CardBrand { get; set; }
    [Column("card_last_four")] public string CardLastFour { get; set; }
    [Column("trial_ends_at")] public DateTime TrialEndsAt { get; set; }
    [Column("contact_id")] public string ContactId { get; set; }
    [Column("country")] public string Country { get; set; }
    [Column("billing_type")] public string BillingType { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }
    [Column("expired_at")] public DateTime ExpiredAt { get; set; }
    [Column("churned_at")] public DateTime ChurnedAt { get; set; }
    [Column("status")] public int Status { get; set; }

}
