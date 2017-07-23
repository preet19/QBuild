using System;
using System.Windows.Forms;

namespace QBuild
{
    partial class QBuildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("BODY_SPOOL");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("TOP_CONE");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("WELD_TOPCONE2SPOOL");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("TOP_STUB");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("BOT_CONE");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("WELD_BOTCONE2SPOOL");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("BOT_STUB");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BON_FLG");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("BON_TOP_PL");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("BON_BOT_PL");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("LIFT_LUG_BODY");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("WELD_LUG_BOD_F");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("WELD_BON_LSR");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("WELD_BON_LSL");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("WELD_BON2FLGBOT");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("WELD_BON2FLG");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("BONNET", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("WELD_BOTCONE_BOT");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("WELD_TOPCONE_TOP");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("SEAT_PL");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("SEAT_STUB");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("WELD_SEATSTUB2CONE");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("SEAT_BOT_CONE");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("SEAT_TOP_CONE");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("WELD_SEATCONES");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("WELD_SEAT2SUPPORT");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("SEAT_PTAB");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("SEAT_PTAB_STRIP");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("SEAT_REFY");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("SEAT", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("LIPSEAL");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("WELD_LIPSEAL");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("BODY_REFY");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("BODY_REFYTOP");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("WELD_SEATCONE");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("BON_RET_ASSY");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("FORM_TOP");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("FORM_SPOOL");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("FORM_RING_TOP");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("FORM_RING_SPL");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("FORM_RING_BOT");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("FORM_SPOOL_ASSY", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("FORM_BON_BOT");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("FORM_BON_L_SPC");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("FORM_BON_R_SPC");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("FORM_BON_TOP");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("FORM_BOLT2");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("FORM_NUT2");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("FORM_BON_ASSY", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("FORM_BODY", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LIFT_LUG_BODY");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("WELD_LUG_BOD_R");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("NAMEPLATE_BRKT");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("WELD_NP_BRKT");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("WELD_BON2BODR");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("WELD_BON2BODL");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("WELD_BON2BODT");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("WELD_BON2BODB");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("WELD_SPOOL_LS");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("KAOWOOL");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("CONE_CARDBOARD");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("BODY_JPAPER");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("BODY_REFY_NEEDLES");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("CARDBOARD");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("JK_PIPE_OS");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("JK_PIPE_IS");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("JK_KAOWOOL");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("WELD_JK_PORT");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("BP_PIPE_OS");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("BP_PIPE_IS");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("BP_KAOWOOL");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("WELD_BP");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("PIPE_BRACE2");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("JACKING_FLG");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("JACKING_BRKT");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("JACK_VALVE");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("BON_VALVE");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("BODY", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67,
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("ORIFICE_GASKET");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("ORIFICE_PL");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("OPLT_RETAINER_BOT");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("OPLT_REFY");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("ORIFICE_PTAB");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("OPLT_PTAB_STRIP");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("ORIFICE", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("DISC_PL");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("WELD_DISC_HF");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("DISC_REFY");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("DISC_TOP_PTAB");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("DISC_BOT_PTAB");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("DISC_HEXMESH");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("DISC_TOP_PTAB_STRIP");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("DISC_BOT_PTAB_STRIP");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("DISC_MTO_PL");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("DISC", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("GUIDE_LH_PL");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("WELD_HF_GUIDE_LH");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("GUIDE_MTO_LH");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("GUIDE_LH", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("GUIDE_RH_PL");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("WELD_HF_GUIDE_RH");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("GUIDE_MTO_RH");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("GUIDE_RH", new System.Windows.Forms.TreeNode[] {
            treeNode100,
            treeNode101,
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("GUIDE_SET", new System.Windows.Forms.TreeNode[] {
            treeNode99,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("STEM_FORG");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("WELD_STEM_HF");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("STEM", new System.Windows.Forms.TreeNode[] {
            treeNode105,
            treeNode106});
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("COV_FLG_PL");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("SBOX_OUTER");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("SBOX_INNER");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("WELD_SBOXES");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("SBOX_EAR");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("WELD_SBOX_EAR");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("WELD_SBOX");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("WELD_SBOX_BACKSEAT");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LIPSEAL");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("WELD_LIPSEAL");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("COV_RETAINER");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("COV_REFY");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("GP_PIPE_OS");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("GP_PIPE_IS");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("GP_JPAPER");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("WELD_GP");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("GP_VALVE");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("LIFT_LUG_COVER");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("WELD_LUG_COV");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("SBP_CPLG_T");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("SBP_CPLG_B");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("SBS_CPLG_T");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("SBS_CPLG_B");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("WELD_SBP_CPLG");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("WELD_SBS_CPLG");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("SBP_PIPE_T");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("SBP_VALVE");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("SBS_PIPE_T");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("SBS_VALVE");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("COV_JPAPER");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("COV_REFY_NEEDLES");
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("ADAPT_FLNG_ACTSIDE");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("YOKE_SIDEPLATE_C");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("WELD_YOKE_2");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("ADAPT_YOKE", new System.Windows.Forms.TreeNode[] {
            treeNode139,
            treeNode140,
            treeNode141});
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("PIPE_BRACE1");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("PIPE_BRACE4");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("PIPE_BRACE3");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("COV_FLG", new System.Windows.Forms.TreeNode[] {
            treeNode108,
            treeNode109,
            treeNode110,
            treeNode111,
            treeNode112,
            treeNode113,
            treeNode114,
            treeNode115,
            treeNode116,
            treeNode117,
            treeNode118,
            treeNode119,
            treeNode120,
            treeNode121,
            treeNode122,
            treeNode123,
            treeNode124,
            treeNode125,
            treeNode126,
            treeNode127,
            treeNode128,
            treeNode129,
            treeNode130,
            treeNode131,
            treeNode132,
            treeNode133,
            treeNode134,
            treeNode135,
            treeNode136,
            treeNode137,
            treeNode138,
            treeNode142,
            treeNode143,
            treeNode144,
            treeNode145});
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("FOLLOW_FLG");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("SBP_PIPEPLUG");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("SBS_PIPEPLUG");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("NAMEPLATE");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("DRIVESCREW");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("NULL_LIPSEAL");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("PACKING_F4");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("PACKING_F3");
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("SLEEVE");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("PACKING_F2");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("LANT_RING");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("SEP_RING");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("PKG_GLAND");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("BOLT_GASKET");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("BOLT_X5");
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("BOLT_N13");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("NUT_N14");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("SPRING_WASH");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("STUD_N1");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("NUT_N2");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("BOLT_N4");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("BOLT_N3");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("BOLT_N5");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("STUD_N6");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("STUD_N8");
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("NUT_N7");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("WARN_TAG_PURGE");
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("WARN_TAG_SEAL");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("DOWEL_COVFLG");
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("BLAC_ACTUATOR");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("ACTUATOR", new System.Windows.Forms.TreeNode[] {
            treeNode176});
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("V_ANC_BOD_V1");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("V_ANC_BOD_V2");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("V_ANC_BOD_V3");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("V_ANC_BOD_V4");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("V_ANC_BOD_V5");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("V_ANC_BOD_V6");
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("V_ANC_BOD_V7");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("V_ANC_BOD_CAP");
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("V_ANC_COV_V1");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("V_ANC_COV_CAP");
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("NULL_ANCHORS", new System.Windows.Forms.TreeNode[] {
            treeNode178,
            treeNode179,
            treeNode180,
            treeNode181,
            treeNode182,
            treeNode183,
            treeNode184,
            treeNode185,
            treeNode186,
            treeNode187});
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("PIPEPLUG200");
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("BOLT_ACT");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("NUT_ACT");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("VALVE", new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode79,
            treeNode85,
            treeNode95,
            treeNode104,
            treeNode107,
            treeNode146,
            treeNode147,
            treeNode148,
            treeNode149,
            treeNode150,
            treeNode151,
            treeNode152,
            treeNode153,
            treeNode154,
            treeNode155,
            treeNode156,
            treeNode157,
            treeNode158,
            treeNode159,
            treeNode160,
            treeNode161,
            treeNode162,
            treeNode163,
            treeNode164,
            treeNode165,
            treeNode166,
            treeNode167,
            treeNode168,
            treeNode169,
            treeNode170,
            treeNode171,
            treeNode172,
            treeNode173,
            treeNode174,
            treeNode175,
            treeNode177,
            treeNode188,
            treeNode189,
            treeNode190,
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("BON_RET_TOP");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("BON_RET_BOT");
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("BON_RET_RSIDE");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("BON_RET_LSIDE");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("BON_RET_ASSY", new System.Windows.Forms.TreeNode[] {
            treeNode193,
            treeNode194,
            treeNode195,
            treeNode196});
            this.QBuildTreeView = new System.Windows.Forms.TreeView();
            this.bomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qBuildDataSet = new QBuild.QBuildDataSet();
            this.bomTableAdapter = new QBuild.QBuildDataSetTableAdapters.bomTableAdapter();
            this.QBuildGridView = new System.Windows.Forms.DataGridView();
            this.populateDataButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.parentLabel = new System.Windows.Forms.Label();
            this.currentBodyLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qBuildDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuildGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QBuildTreeView
            // 
            this.QBuildTreeView.Location = new System.Drawing.Point(23, 50);
            this.QBuildTreeView.Name = "QBuildTreeView";
            treeNode1.Name = "BODY_SPOOL";
            treeNode1.Text = "BODY_SPOOL";
            treeNode2.Name = "TOP_CONE";
            treeNode2.Text = "TOP_CONE";
            treeNode3.Name = "WELD_TOPCONE2SPOOL";
            treeNode3.Text = "WELD_TOPCONE2SPOOL";
            treeNode4.Name = "TOP_STUB";
            treeNode4.Text = "TOP_STUB";
            treeNode5.Name = "BOT_CONE";
            treeNode5.Text = "BOT_CONE";
            treeNode6.Name = "WELD_BOTCONE2SPOOL";
            treeNode6.Text = "WELD_BOTCONE2SPOOL";
            treeNode7.Name = "BOT_STUB";
            treeNode7.Text = "BOT_STUB";
            treeNode8.Name = "BON_FLG";
            treeNode8.Text = "BON_FLG";
            treeNode9.Name = "BON_TOP_PL";
            treeNode9.Text = "BON_TOP_PL";
            treeNode10.Name = "BON_BOT_PL";
            treeNode10.Text = "BON_BOT_PL";
            treeNode11.Name = "LIFT_LUG_BODY";
            treeNode11.Text = "LIFT_LUG_BODY";
            treeNode12.Name = "WELD_LUG_BOD_F";
            treeNode12.Text = "WELD_LUG_BOD_F";
            treeNode13.Name = "WELD_BON_LSR";
            treeNode13.Text = "WELD_BON_LSR";
            treeNode14.Name = "WELD_BON_LSL";
            treeNode14.Text = "WELD_BON_LSL";
            treeNode15.Name = "WELD_BON2FLGBOT";
            treeNode15.Text = "WELD_BON2FLGBOT";
            treeNode16.Name = "WELD_BON2FLG";
            treeNode16.Text = "WELD_BON2FLG";
            treeNode17.Name = "BONNET";
            treeNode17.Text = "BONNET";
            treeNode18.Name = "WELD_BOTCONE_BOT";
            treeNode18.Text = "WELD_BOTCONE_BOT";
            treeNode19.Name = "WELD_TOPCONE_TOP";
            treeNode19.Text = "WELD_TOPCONE_TOP";
            treeNode20.Name = "SEAT_PL";
            treeNode20.Text = "SEAT_PL";
            treeNode21.Name = "SEAT_STUB";
            treeNode21.Text = "SEAT_STUB";
            treeNode22.Name = "WELD_SEATSTUB2CONE";
            treeNode22.Text = "WELD_SEATSTUB2CONE";
            treeNode23.Name = "SEAT_BOT_CONE";
            treeNode23.Text = "SEAT_BOT_CONE";
            treeNode24.Name = "SEAT_TOP_CONE";
            treeNode24.Text = "SEAT_TOP_CONE";
            treeNode25.Name = "WELD_SEATCONES";
            treeNode25.Text = "WELD_SEATCONES";
            treeNode26.Name = "WELD_SEAT2SUPPORT";
            treeNode26.Text = "WELD_SEAT2SUPPORT";
            treeNode27.Name = "SEAT_PTAB";
            treeNode27.Text = "SEAT_PTAB";
            treeNode28.Name = "SEAT_PTAB_STRIP";
            treeNode28.Text = "SEAT_PTAB_STRIP";
            treeNode29.Name = "SEAT_REFY";
            treeNode29.Text = "SEAT_REFY";
            treeNode30.Name = "SEAT";
            treeNode30.Text = "SEAT";
            treeNode31.Name = "LIPSEAL";
            treeNode31.Text = "LIPSEAL";
            treeNode32.Name = "WELD_LIPSEAL";
            treeNode32.Text = "WELD_LIPSEAL";
            treeNode33.Name = "BODY_REFY";
            treeNode33.Text = "BODY_REFY";
            treeNode34.Name = "BODY_REFYTOP";
            treeNode34.Text = "BODY_REFYTOP";
            treeNode35.Name = "WELD_SEATCONE";
            treeNode35.Text = "WELD_SEATCONE";
            treeNode36.Name = "BON_RET_ASSY";
            treeNode36.Text = "BON_RET_ASSY";
            treeNode37.Name = "FORM_TOP";
            treeNode37.Text = "FORM_TOP";
            treeNode38.Name = "FORM_SPOOL";
            treeNode38.Text = "FORM_SPOOL";
            treeNode39.Name = "FORM_RING_TOP";
            treeNode39.Text = "FORM_RING_TOP";
            treeNode40.Name = "FORM_RING_SPL";
            treeNode40.Text = "FORM_RING_SPL";
            treeNode41.Name = "FORM_RING_BOT";
            treeNode41.Text = "FORM_RING_BOT";
            treeNode42.Name = "FORM_SPOOL_ASSY";
            treeNode42.Text = "FORM_SPOOL_ASSY";
            treeNode43.Name = "FORM_BON_BOT";
            treeNode43.Text = "FORM_BON_BOT";
            treeNode44.Name = "FORM_BON_L_SPC";
            treeNode44.Text = "FORM_BON_L_SPC";
            treeNode45.Name = "FORM_BON_R_SPC";
            treeNode45.Text = "FORM_BON_R_SPC";
            treeNode46.Name = "FORM_BON_TOP";
            treeNode46.Text = "FORM_BON_TOP";
            treeNode47.Name = "FORM_BOLT2";
            treeNode47.Text = "FORM_BOLT2";
            treeNode48.Name = "FORM_NUT2";
            treeNode48.Text = "FORM_NUT2";
            treeNode49.Name = "FORM_BON_ASSY";
            treeNode49.Text = "FORM_BON_ASSY";
            treeNode50.Name = "FORM_BODY";
            treeNode50.Text = "FORM_BODY";
            treeNode51.Name = "LIFT_LUG_BODY";
            treeNode51.Text = "LIFT_LUG_BODY";
            treeNode52.Name = "WELD_LUG_BOD_R";
            treeNode52.Text = "WELD_LUG_BOD_R";
            treeNode53.Name = "NAMEPLATE_BRKT";
            treeNode53.Text = "NAMEPLATE_BRKT";
            treeNode54.Name = "WELD_NP_BRKT";
            treeNode54.Text = "WELD_NP_BRKT";
            treeNode55.Name = "WELD_BON2BODR";
            treeNode55.Text = "WELD_BON2BODR";
            treeNode56.Name = "WELD_BON2BODL";
            treeNode56.Text = "WELD_BON2BODL";
            treeNode57.Name = "WELD_BON2BODT";
            treeNode57.Text = "WELD_BON2BODT";
            treeNode58.Name = "WELD_BON2BODB";
            treeNode58.Text = "WELD_BON2BODB";
            treeNode59.Name = "WELD_SPOOL_LS";
            treeNode59.Text = "WELD_SPOOL_LS";
            treeNode60.Name = "KAOWOOL";
            treeNode60.Text = "KAOWOOL";
            treeNode61.Name = "CONE_CARDBOARD";
            treeNode61.Text = "CONE_CARDBOARD";
            treeNode62.Name = "BODY_JPAPER";
            treeNode62.Text = "BODY_JPAPER";
            treeNode63.Name = "BODY_REFY_NEEDLES";
            treeNode63.Text = "BODY_REFY_NEEDLES";
            treeNode64.Name = "CARDBOARD";
            treeNode64.Text = "CARDBOARD";
            treeNode65.Name = "JK_PIPE_OS";
            treeNode65.Text = "JK_PIPE_OS";
            treeNode66.Name = "JK_PIPE_IS";
            treeNode66.Text = "JK_PIPE_IS";
            treeNode67.Name = "JK_KAOWOOL";
            treeNode67.Text = "JK_KAOWOOL";
            treeNode68.Name = "WELD_JK_PORT";
            treeNode68.Text = "WELD_JK_PORT";
            treeNode69.Name = "BP_PIPE_OS";
            treeNode69.Text = "BP_PIPE_OS";
            treeNode70.Name = "BP_PIPE_IS";
            treeNode70.Text = "BP_PIPE_IS";
            treeNode71.Name = "BP_KAOWOOL";
            treeNode71.Text = "BP_KAOWOOL";
            treeNode72.Name = "WELD_BP";
            treeNode72.Text = "WELD_BP";
            treeNode73.Name = "PIPE_BRACE2";
            treeNode73.Text = "PIPE_BRACE2";
            treeNode74.Name = "JACKING_FLG";
            treeNode74.Text = "JACKING_FLG";
            treeNode75.Name = "JACKING_BRKT";
            treeNode75.Text = "JACKING_BRKT";
            treeNode76.Name = "JACK_VALVE";
            treeNode76.Text = "JACK_VALVE";
            treeNode77.Name = "BON_VALVE";
            treeNode77.Text = "BON_VALVE";
            treeNode78.Name = "BODY";
            treeNode78.Text = "BODY";
            treeNode79.Name = "ORIFICE_GASKET";
            treeNode79.Text = "ORIFICE_GASKET";
            treeNode80.Name = "ORIFICE_PL";
            treeNode80.Text = "ORIFICE_PL";
            treeNode81.Name = "OPLT_RETAINER_BOT";
            treeNode81.Text = "OPLT_RETAINER_BOT";
            treeNode82.Name = "OPLT_REFY";
            treeNode82.Text = "OPLT_REFY";
            treeNode83.Name = "ORIFICE_PTAB";
            treeNode83.Text = "ORIFICE_PTAB";
            treeNode84.Name = "OPLT_PTAB_STRIP";
            treeNode84.Text = "OPLT_PTAB_STRIP";
            treeNode85.Name = "ORIFICE";
            treeNode85.Text = "ORIFICE";
            treeNode86.Name = "DISC_PL";
            treeNode86.Text = "DISC_PL";
            treeNode87.Name = "WELD_DISC_HF";
            treeNode87.Text = "WELD_DISC_HF";
            treeNode88.Name = "DISC_REFY";
            treeNode88.Text = "DISC_REFY";
            treeNode89.Name = "DISC_TOP_PTAB";
            treeNode89.Text = "DISC_TOP_PTAB";
            treeNode90.Name = "DISC_BOT_PTAB";
            treeNode90.Text = "DISC_BOT_PTAB";
            treeNode91.Name = "DISC_HEXMESH";
            treeNode91.Text = "DISC_HEXMESH";
            treeNode92.Name = "DISC_TOP_PTAB_STRIP";
            treeNode92.Text = "DISC_TOP_PTAB_STRIP";
            treeNode93.Name = "DISC_BOT_PTAB_STRIP";
            treeNode93.Text = "DISC_BOT_PTAB_STRIP";
            treeNode94.Name = "DISC_MTO_PL";
            treeNode94.Text = "DISC_MTO_PL";
            treeNode95.Name = "DISC";
            treeNode95.Text = "DISC";
            treeNode96.Name = "GUIDE_LH_PL";
            treeNode96.Text = "GUIDE_LH_PL";
            treeNode97.Name = "WELD_HF_GUIDE_LH";
            treeNode97.Text = "WELD_HF_GUIDE_LH";
            treeNode98.Name = "GUIDE_MTO_LH";
            treeNode98.Text = "GUIDE_MTO_LH";
            treeNode99.Name = "GUIDE_LH";
            treeNode99.Text = "GUIDE_LH";
            treeNode100.Name = "GUIDE_RH_PL";
            treeNode100.Text = "GUIDE_RH_PL";
            treeNode101.Name = "WELD_HF_GUIDE_RH";
            treeNode101.Text = "WELD_HF_GUIDE_RH";
            treeNode102.Name = "GUIDE_MTO_RH";
            treeNode102.Text = "GUIDE_MTO_RH";
            treeNode103.Name = "GUIDE_RH";
            treeNode103.Text = "GUIDE_RH";
            treeNode104.Name = "GUIDE_SET";
            treeNode104.Text = "GUIDE_SET";
            treeNode105.Name = "STEM_FORG";
            treeNode105.Text = "STEM_FORG";
            treeNode106.Name = "WELD_STEM_HF";
            treeNode106.Text = "WELD_STEM_HF";
            treeNode107.Name = "STEM";
            treeNode107.Text = "STEM";
            treeNode108.Name = "COV_FLG_PL";
            treeNode108.Text = "COV_FLG_PL";
            treeNode109.Name = "SBOX_OUTER";
            treeNode109.Text = "SBOX_OUTER";
            treeNode110.Name = "SBOX_INNER";
            treeNode110.Text = "SBOX_INNER";
            treeNode111.Name = "WELD_SBOXES";
            treeNode111.Text = "WELD_SBOXES";
            treeNode112.Name = "SBOX_EAR";
            treeNode112.Text = "SBOX_EAR";
            treeNode113.Name = "WELD_SBOX_EAR";
            treeNode113.Text = "WELD_SBOX_EAR";
            treeNode114.Name = "WELD_SBOX";
            treeNode114.Text = "WELD_SBOX";
            treeNode115.Name = "WELD_SBOX_BACKSEAT";
            treeNode115.Text = "WELD_SBOX_BACKSEAT";
            treeNode116.Name = "LIPSEAL";
            treeNode116.Text = "LIPSEAL";
            treeNode117.Name = "WELD_LIPSEAL";
            treeNode117.Text = "WELD_LIPSEAL";
            treeNode118.Name = "COV_RETAINER";
            treeNode118.Text = "COV_RETAINER";
            treeNode119.Name = "COV_REFY";
            treeNode119.Text = "COV_REFY";
            treeNode120.Name = "GP_PIPE_OS";
            treeNode120.Text = "GP_PIPE_OS";
            treeNode121.Name = "GP_PIPE_IS";
            treeNode121.Text = "GP_PIPE_IS";
            treeNode122.Name = "GP_JPAPER";
            treeNode122.Text = "GP_JPAPER";
            treeNode123.Name = "WELD_GP";
            treeNode123.Text = "WELD_GP";
            treeNode124.Name = "GP_VALVE";
            treeNode124.Text = "GP_VALVE";
            treeNode125.Name = "LIFT_LUG_COVER";
            treeNode125.Text = "LIFT_LUG_COVER";
            treeNode126.Name = "WELD_LUG_COV";
            treeNode126.Text = "WELD_LUG_COV";
            treeNode127.Name = "SBP_CPLG_T";
            treeNode127.Text = "SBP_CPLG_T";
            treeNode128.Name = "SBP_CPLG_B";
            treeNode128.Text = "SBP_CPLG_B";
            treeNode129.Name = "SBS_CPLG_T";
            treeNode129.Text = "SBS_CPLG_T";
            treeNode130.Name = "SBS_CPLG_B";
            treeNode130.Text = "SBS_CPLG_B";
            treeNode131.Name = "WELD_SBP_CPLG";
            treeNode131.Text = "WELD_SBP_CPLG";
            treeNode132.Name = "WELD_SBS_CPLG";
            treeNode132.Text = "WELD_SBS_CPLG";
            treeNode133.Name = "SBP_PIPE_T";
            treeNode133.Text = "SBP_PIPE_T";
            treeNode134.Name = "SBP_VALVE";
            treeNode134.Text = "SBP_VALVE";
            treeNode135.Name = "SBS_PIPE_T";
            treeNode135.Text = "SBS_PIPE_T";
            treeNode136.Name = "SBS_VALVE";
            treeNode136.Text = "SBS_VALVE";
            treeNode137.Name = "COV_JPAPER";
            treeNode137.Text = "COV_JPAPER";
            treeNode138.Name = "COV_REFY_NEEDLES";
            treeNode138.Text = "COV_REFY_NEEDLES";
            treeNode139.Name = "ADAPT_FLNG_ACTSIDE";
            treeNode139.Text = "ADAPT_FLNG_ACTSIDE";
            treeNode140.Name = "YOKE_SIDEPLATE_C";
            treeNode140.Text = "YOKE_SIDEPLATE_C";
            treeNode141.Name = "WELD_YOKE_2";
            treeNode141.Text = "WELD_YOKE_2";
            treeNode142.Name = "ADAPT_YOKE";
            treeNode142.Text = "ADAPT_YOKE";
            treeNode143.Name = "PIPE_BRACE1";
            treeNode143.Text = "PIPE_BRACE1";
            treeNode144.Name = "PIPE_BRACE4";
            treeNode144.Text = "PIPE_BRACE4";
            treeNode145.Name = "PIPE_BRACE3";
            treeNode145.Text = "PIPE_BRACE3";
            treeNode146.Name = "COV_FLG";
            treeNode146.Text = "COV_FLG";
            treeNode147.Name = "FOLLOW_FLG";
            treeNode147.Text = "FOLLOW_FLG";
            treeNode148.Name = "SBP_PIPEPLUG";
            treeNode148.Text = "SBP_PIPEPLUG";
            treeNode149.Name = "SBS_PIPEPLUG";
            treeNode149.Text = "SBS_PIPEPLUG";
            treeNode150.Name = "NAMEPLATE";
            treeNode150.Text = "NAMEPLATE";
            treeNode151.Name = "DRIVESCREW";
            treeNode151.Text = "DRIVESCREW";
            treeNode152.Name = "NULL_LIPSEAL";
            treeNode152.Text = "NULL_LIPSEAL";
            treeNode153.Name = "PACKING_F4";
            treeNode153.Text = "PACKING_F4";
            treeNode154.Name = "PACKING_F3";
            treeNode154.Text = "PACKING_F3";
            treeNode155.Name = "SLEEVE";
            treeNode155.Text = "SLEEVE";
            treeNode156.Name = "PACKING_F2";
            treeNode156.Text = "PACKING_F2";
            treeNode157.Name = "LANT_RING";
            treeNode157.Text = "LANT_RING";
            treeNode158.Name = "SEP_RING";
            treeNode158.Text = "SEP_RING";
            treeNode159.Name = "PKG_GLAND";
            treeNode159.Text = "PKG_GLAND";
            treeNode160.Name = "BOLT_GASKET";
            treeNode160.Text = "BOLT_GASKET";
            treeNode161.Name = "BOLT_X5";
            treeNode161.Text = "BOLT_X5";
            treeNode162.Name = "BOLT_N13";
            treeNode162.Text = "BOLT_N13";
            treeNode163.Name = "NUT_N14";
            treeNode163.Text = "NUT_N14";
            treeNode164.Name = "SPRING_WASH";
            treeNode164.Text = "SPRING_WASH";
            treeNode165.Name = "STUD_N1";
            treeNode165.Text = "STUD_N1";
            treeNode166.Name = "NUT_N2";
            treeNode166.Text = "NUT_N2";
            treeNode167.Name = "BOLT_N4";
            treeNode167.Text = "BOLT_N4";
            treeNode168.Name = "BOLT_N3";
            treeNode168.Text = "BOLT_N3";
            treeNode169.Name = "BOLT_N5";
            treeNode169.Text = "BOLT_N5";
            treeNode170.Name = "STUD_N6";
            treeNode170.Text = "STUD_N6";
            treeNode171.Name = "STUD_N8";
            treeNode171.Text = "STUD_N8";
            treeNode172.Name = "NUT_N7";
            treeNode172.Text = "NUT_N7";
            treeNode173.Name = "WARN_TAG_PURGE";
            treeNode173.Text = "WARN_TAG_PURGE";
            treeNode174.Name = "WARN_TAG_SEAL";
            treeNode174.Text = "WARN_TAG_SEAL";
            treeNode175.Name = "DOWEL_COVFLG";
            treeNode175.Text = "DOWEL_COVFLG";
            treeNode176.Name = "BLAC_ACTUATOR";
            treeNode176.Text = "BLAC_ACTUATOR";
            treeNode177.Name = "ACTUATOR";
            treeNode177.Text = "ACTUATOR";
            treeNode178.Name = "V_ANC_BOD_V1";
            treeNode178.Text = "V_ANC_BOD_V1";
            treeNode179.Name = "V_ANC_BOD_V2";
            treeNode179.Text = "V_ANC_BOD_V2";
            treeNode180.Name = "V_ANC_BOD_V3";
            treeNode180.Text = "V_ANC_BOD_V3";
            treeNode181.Name = "V_ANC_BOD_V4";
            treeNode181.Text = "V_ANC_BOD_V4";
            treeNode182.Name = "V_ANC_BOD_V5";
            treeNode182.Text = "V_ANC_BOD_V5";
            treeNode183.Name = "V_ANC_BOD_V6";
            treeNode183.Text = "V_ANC_BOD_V6";
            treeNode184.Name = "V_ANC_BOD_V7";
            treeNode184.Text = "V_ANC_BOD_V7";
            treeNode185.Name = "V_ANC_BOD_CAP";
            treeNode185.Text = "V_ANC_BOD_CAP";
            treeNode186.Name = "V_ANC_COV_V1";
            treeNode186.Text = "V_ANC_COV_V1";
            treeNode187.Name = "V_ANC_COV_CAP";
            treeNode187.Text = "V_ANC_COV_CAP";
            treeNode188.Name = "NULL_ANCHORS";
            treeNode188.Text = "NULL_ANCHORS";
            treeNode189.Name = "PIPEPLUG200";
            treeNode189.Text = "PIPEPLUG200";
            treeNode190.Name = "BOLT_ACT";
            treeNode190.Text = "BOLT_ACT";
            treeNode191.Name = "NUT_ACT";
            treeNode191.Text = "NUT_ACT";
            treeNode192.Name = "VALVE";
            treeNode192.Text = "VALVE";
            treeNode193.Name = "BON_RET_TOP";
            treeNode193.Text = "BON_RET_TOP";
            treeNode194.Name = "BON_RET_BOT";
            treeNode194.Text = "BON_RET_BOT";
            treeNode195.Name = "BON_RET_RSIDE";
            treeNode195.Text = "BON_RET_RSIDE";
            treeNode196.Name = "BON_RET_LSIDE";
            treeNode196.Text = "BON_RET_LSIDE";
            treeNode197.Name = "BON_RET_ASSY";
            treeNode197.Text = "BON_RET_ASSY";
            this.QBuildTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode192,
            treeNode197});
            this.QBuildTreeView.Size = new System.Drawing.Size(289, 163);
            this.QBuildTreeView.TabIndex = 0;
            this.QBuildTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // bomBindingSource
            // 
            this.bomBindingSource.DataMember = "bom";
            this.bomBindingSource.DataSource = this.qBuildDataSet;
            // 
            // qBuildDataSet
            // 
            this.qBuildDataSet.DataSetName = "QBuildDataSet";
            this.qBuildDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bomTableAdapter
            // 
            this.bomTableAdapter.ClearBeforeFill = true;
            // 
            // QBuildGridView
            // 
            this.QBuildGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QBuildGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.QBuildGridView.Location = new System.Drawing.Point(23, 224);
            this.QBuildGridView.Name = "QBuildGridView";
            this.QBuildGridView.Size = new System.Drawing.Size(729, 189);
            this.QBuildGridView.TabIndex = 1;
            this.QBuildGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // populateDataButton
            // 
            this.populateDataButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populateDataButton.Location = new System.Drawing.Point(386, 124);
            this.populateDataButton.Name = "populateDataButton";
            this.populateDataButton.Size = new System.Drawing.Size(154, 23);
            this.populateDataButton.TabIndex = 2;
            this.populateDataButton.Text = "Populate Data in Tree";
            this.populateDataButton.UseVisualStyleBackColor = true;
            this.populateDataButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(386, 153);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(154, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit from Application";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // parentLabel
            // 
            this.parentLabel.AutoSize = true;
            this.parentLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentLabel.Location = new System.Drawing.Point(383, 62);
            this.parentLabel.Name = "parentLabel";
            this.parentLabel.Size = new System.Drawing.Size(104, 14);
            this.parentLabel.TabIndex = 4;
            this.parentLabel.Text = "Parent Child Part : ";
            this.parentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentBodyLabel
            // 
            this.currentBodyLabel.AutoSize = true;
            this.currentBodyLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBodyLabel.Location = new System.Drawing.Point(383, 88);
            this.currentBodyLabel.Name = "currentBodyLabel";
            this.currentBodyLabel.Size = new System.Drawing.Size(82, 14);
            this.currentBodyLabel.TabIndex = 4;
            this.currentBodyLabel.Text = "Current Body :";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Maroon;
            this.headerLabel.Location = new System.Drawing.Point(275, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(264, 17);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Testing Functionality for Tree and Grid";
            // 
            // QBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 425);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.currentBodyLabel);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.populateDataButton);
            this.Controls.Add(this.QBuildGridView);
            this.Controls.Add(this.QBuildTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QBuildForm";
            this.Text = "QBuild";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qBuildDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuildGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TreeView QBuildTreeView;
        private QBuildDataSet qBuildDataSet;
        private System.Windows.Forms.BindingSource bomBindingSource;
        private QBuildDataSetTableAdapters.bomTableAdapter bomTableAdapter;
        private System.Windows.Forms.DataGridView QBuildGridView;
        private Button populateDataButton;
        private Button Exit;
        private Label parentLabel;
        private Label currentBodyLabel;
        private Label headerLabel;
    }
}

