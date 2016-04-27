using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aperture_Social_Service {
    class ATweet {
        private string content;
        private int id;
        private long idOnline;
        public ATweet(string content, int id, long idOnline) {
            this.content = content;
            this.id = id;
            this.idOnline = idOnline;
        }
        public string GetContent() {
            return content;
        }

        public string SetContent(string content) {
            return this.content = content;
        }

        public int GetID() {
            return id;
        }
        public int SetID(int i) {
            return this.id = i;
        }
        public long GetIDOnline() {
            return idOnline;
        }
        public long SetIDOnline(long i) {
            return this.idOnline = i;
        }
    }
}
