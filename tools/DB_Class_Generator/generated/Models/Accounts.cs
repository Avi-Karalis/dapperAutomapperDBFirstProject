using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AdminPanel.ModelsAndRepository.Interfaces;

[Table("accounts")]
public class Accounts : IEntity {
    [Column("id")] public string Id { get; set; }
    [Column("selected_company_id")] public string SelectedCompanyId { get; set; }
    [Column("sis_user_id")] public string SisUserId { get; set; }
    [Column("integration_id")] public string IntegrationId { get; set; }
    [Column("uuid")] public string Uuid { get; set; }
    [Column("firstname")] public string Firstname { get; set; }
    [Column("lastname")] public string Lastname { get; set; }
    [Column("username")] public string Username { get; set; }
    [Column("email")] public string Email { get; set; }
    [Column("password")] public string Password { get; set; }
    [Column("headline")] public string Headline { get; set; }
    [Column("biography")] public string Biography { get; set; }
    [Column("media_id")] public string MediaId { get; set; }
    [Column("phone_number")] public string PhoneNumber { get; set; }
    [Column("company_name")] public string CompanyName { get; set; }
    [Column("city")] public string City { get; set; }
    [Column("department")] public string Department { get; set; }
    [Column("background_image_id")] public string BackgroundImageId { get; set; }
    [Column("date_format")] public string DateFormat { get; set; }
    [Column("timezone")] public string Timezone { get; set; }
    [Column("upload_folder_id")] public string UploadFolderId { get; set; }
    [Column("legal_mentions")] public bool LegalMentions { get; set; }
    [Column("created_at")] public DateTime CreatedAt { get; set; }
    [Column("updated_at")] public DateTime UpdatedAt { get; set; }
    [Column("last_connection")] public DateTime LastConnection { get; set; }
    [Column("deleted_at")] public DateTime DeletedAt { get; set; }
    [Column("onboarding")] public bool Onboarding { get; set; }
    [Column("product_tour")] public string ProductTour { get; set; }
    [Column("reason")] public string Reason { get; set; }
    [Column("invitation_id")] public string InvitationId { get; set; }
    [Column("type")] public string Type { get; set; }
    [Column("language_id")] public string LanguageId { get; set; }
    [Column("status")] public string Status { get; set; }
    [Column("pc_meta")] public string PcMeta { get; set; }
    [Column("roles")] public string Roles { get; set; }

}
