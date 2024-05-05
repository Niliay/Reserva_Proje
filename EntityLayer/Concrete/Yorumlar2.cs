using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorumlar2
    {
        [Key]
        public int Yorumlar2ID { get; set; } //commentID
        public string Yorumlar2Kullanıcı { get; set; } //CommentUser
        public DateTime Yorumlar2Tarih { get; set; }//commentDate
        public string Yorumlar2Icerik { get; set; } //CommentContent
        public bool Yorumlar2Durum { get; set; } //commentState
        public int TatilYerleriID { get; set; }//otellerotellerıd

        //yORUMLAR2 İLE TATİL YERLEİ ARASI BAĞLANTI:
        public TatilYerleri TatilYerleri { get; set; }
    }
}
