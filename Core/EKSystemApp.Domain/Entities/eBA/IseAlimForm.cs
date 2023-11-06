using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA
{
    [Table("E_mrs_IseAlimTurkuvaz_Form")]
    public class IseAlimForm
    {
        [Key]
        public int ID { get; set; }
        public int? chkIKGrupBaskanOnay { get; set; }
        public int? txtPersonelSayi { get; set; }
        public int? txtDeneyimYilEnFazla { get; set; }
        public int? txtYasEnFazla { get; set; }
        public int? txtYasEnAz { get; set; }
        public int? txtDeneyimYilEnAz { get; set; }
        public int? chkAltSurecIptalBeyan { get; set; }
        public int? chkBaskaDepartman { get; set; }
        public int? Secim1 { get; set; }
        public int? Secim2 { get; set; }
        public int? chkUcretGoster { get; set; }
        public DateTime? txtIseBaslamaIstenilenTarih { get; set; }
        public DateTime? txtFormTarih { get; set; }
        public decimal? txtUcretEnAz { get; set; }
        public decimal? txtUcretEnFazla { get; set; }
        public string? txtIsTanim { get; set; }
        public string? txtTalepAcanEposta { get; set; }
        public string? txtTalepAcanAdSoyad { get; set; }
        public string? txtTalepAcanOrganizasyon { get; set; }
        public string? txtTalepAcanSirket { get; set; }
        public string? txtTalepAcanBolum { get; set; }
        public string? txtTalepAcanGrup { get; set; }
        public string? txtTalepAcanBirim { get; set; }
        public string? txtTalepAcanGorev { get; set; }
        public string? cmbBolum { get; set; }
        public string? cmbBolum_TEXT { get; set; }
        public string? cmbBirim { get; set; }
        public string? cmbBirim_TEXT { get; set; }
        public string? cmbGrup { get; set; }
        public string? cmbGrup_TEXT { get; set; }
        public string? cmbTuzelKisilik { get; set; }
        public string? cmbTuzelKisilik_TEXT { get; set; }
        public string? cmbSirket { get; set; }
        public string? cmbSirket_TEXT { get; set; }
        public string? cmbLokasyon { get; set; }
        public string? cmbLokasyon_TEXT { get; set; }
        public string? cmbOrganizasyon { get; set; }
        public string? cmbOrganizasyon_TEXT { get; set; }
        public string? cmbUnvan { get; set; }
        public string? cmbUnvan_TEXT { get; set; }
        public string? cmbGorev { get; set; }
        public string? cmbGorev_TEXT { get; set; }
        public string? txtUnvanNo { get; set; }
        public string? txtYorum { get; set; }
        public string? txteBASurecNo { get; set; }
        public string? cmbKadroDurum { get; set; }
        public string? cmbKadroDurum_TEXT { get; set; }
        public string? txtAdSoyadBosKadro { get; set; }
        public string? txtTalepNeden { get; set; }
        public string? cmbCalismaSekli { get; set; }
        public string? cmbCalismaSekli_TEXT { get; set; }
        public string? cmbCinsiyet { get; set; }
        public string? cmbCinsiyet_TEXT { get; set; }
        public string? cmbEgitimDurum { get; set; }
        public string? cmbEgitimDurum_TEXT { get; set; }
        public string? cmbVardiyaDurum { get; set; }
        public string? cmbVardiyaDurum_TEXT { get; set; }
        public string? cmbAskerlikDurumu { get; set; }
        public string? cmbAskerlikDurumu_TEXT { get; set; }
        public string? cmbButceDurum { get; set; }
        public string? cmbButceDurum_TEXT { get; set; }
        public string? cmbUcretParaBirimi { get; set; }
        public string? cmbUcretParaBirimi_TEXT { get; set; }
        public string? cmbKadroSekli { get; set; }
        public string? cmbKadroSekli_TEXT { get; set; }
        public string? txtEklenenPersonelSayi { get; set; }
        public string? cmbPersonel { get; set; }
        public string? cmbPersonel_TEXT { get; set; }
        public string? txtAkisBaslatanKontrol { get; set; }
        public string? txtGrupBaskanOnayKontrol { get; set; }
        public string? txtAkisAdimi { get; set; }
        public string? txtAkisBaslatanTip { get; set; }
        public string? txtTalepAcanSicil { get; set; }
        public string? txtDepartmanKontrol { get; set; }
        public string? txtMudurUstuMu { get; set; }
        public string? txtFormId { get; set; }
        public string? txtTalepBilgiKitle { get; set; }
        public string? txtDilHata { get; set; }
        public string? cmbSureTip { get; set; }
        public string? cmbSureTip_TEXT { get; set; }
        public string? txtSureliMi { get; set; }
        public string? txtIKGrupBaskanCheckROKontrol { get; set; }
        public string? txtBaskaDepartmanMi { get; set; }
        public string? txtUcretEnAzSifreli { get; set; }
        public string? txtUcretEnFazlaSifreli { get; set; }
        public string? txtTalepAcanOrgKey { get; set; }
        public string? txtOrgKey { get; set; }
        public string? txtRequestId { get; set; }
        public string? cmbSureTip2 { get; set; }
        public string? cmbSureTip2_TEXT { get; set; }
    }
}
