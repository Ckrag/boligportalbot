using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligportalbot
{
    class QueryTest
    {
        string[] test_array = 
            {"{'amtId':'0','huslejeMin':'0','huslejeMax':'4000','stoerrelseMin':'0','stoerrelseMax':'0','postnrArr':[],'boligTypeArr':['9'],'lejeLaengdeArr':['4'],'page':'1','limit':'15','sortCol':'3','sortDesc':'1','visOnSiteBolig':0,'almen':-1,'billeder':-1,'husdyr':-1,'mobleret':-1,'delevenlig':-1,'fritekst':'','overtagdato':'','emailservice':'','kunNyeste':false,'muListeMuId':'','fremleje':-1}",
            "{'amtId':'0','huslejeMin':'0','huslejeMax':'4000','stoerrelseMin':'0','stoerrelseMax':'0','postnrArr':[],'boligTypeArr':['2','3','9'],'lejeLaengdeArr':['4'],'page':'1','limit':'15','sortCol':'3','sortDesc':'1','visOnSiteBolig':0,'almen':-1,'billeder':-1,'husdyr':-1,'mobleret':-1,'delevenlig':-1,'fritekst':'','overtagdato':'','emailservice':'','kunNyeste':false,'muListeMuId':'','fremleje':-1}",
            "{'amtId':'0','huslejeMin':'0','huslejeMax':'10000','stoerrelseMin':'0','stoerrelseMax':'0','postnrArr':[],'boligTypeArr':['2','3','9'],'lejeLaengdeArr':['4'],'page':'1','limit':'15','sortCol':'3','sortDesc':'1','visOnSiteBolig':0,'almen':-1,'billeder':-1,'husdyr':-1,'mobleret':-1,'delevenlig':-1,'fritekst':'','overtagdato':'','emailservice':'','kunNyeste':false,'muListeMuId':'','fremleje':-1}"};
        string test_string;


        int current_number = 0;
        private void fixed_output_btn_Click(object sender, EventArgs e)
        {
            
            if (current_number >= 2)
            {
                current_number = 0;
            }
            else
            {
                test_string = test_array[current_number];
                current_number++;
            }     
        }
    }
}
