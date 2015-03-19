using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;
using System.ComponentModel;
using WFMT.ASAC.DAL;
using WFMT.ASAC.Models;



namespace WFMT.ASAC.DAL
{
    class AgentSkillAssignmentsData
    {
    #region Data Columns (Actual Data Layout)
        #region Unique Columns
                [CsvColumn(Name = "Login ID", FieldIndex = 1)]
                public int Login_ID { get; set; }
                [CsvColumn(Name = "Extn", FieldIndex = 2)]
                public string Extn { get; set; }
                [CsvColumn(Name = "Name", FieldIndex = 3)]
                public string Name { get; set; }
                [CsvColumn(Name = "Dir Agt", FieldIndex = 4)]
                public string Dir_Agt { get; set; } //Not important
                [CsvColumn(Name = "AAS/AUD", FieldIndex = 5)]
                public string AAS_AUD { get; set; } //Not important
                [CsvColumn(Name = "COR", FieldIndex = 6)]
                public int COR { get; set; }
                [CsvColumn(Name = "Agt Prf", FieldIndex = 7)]
                public string Agt_Prf { get; set; }
            #endregion

        //I know this is nuts but we're stuck with the data in this format, and need the model to reflect the data layout for import...
        #region 120 Skill/Priority Column Pairs
                //Start of 120 x Skl/Lvl attributes pairs
                [CsvColumn(Name = "Skl 1", FieldIndex = 8)]
                public int Skl_1 { get; set; }
                [CsvColumn(Name = "Lvl 1", FieldIndex = 9)]
                public string Lvl_1 { get; set; }
                [CsvColumn(Name = "Skl 2", FieldIndex = 10)]
                public int Skl_2 { get; set; }
                [CsvColumn(Name = "Lvl 2", FieldIndex = 11)]
                public string Lvl_2 { get; set; }
                [CsvColumn(Name = "Skl 3", FieldIndex = 12)]
                public int Skl_3 { get; set; }
                [CsvColumn(Name = "Lvl 3", FieldIndex = 13)]
                public string Lvl_3 { get; set; }
                [CsvColumn(Name = "Skl 4", FieldIndex = 14)]
                public int Skl_4 { get; set; }
                [CsvColumn(Name = "Lvl 4", FieldIndex = 15)]
                public string Lvl_4 { get; set; }
                [CsvColumn(Name = "Skl 5", FieldIndex = 16)]
                public int Skl_5 { get; set; }
                [CsvColumn(Name = "Lvl 5", FieldIndex = 17)]
                public string Lvl_5 { get; set; }
                [CsvColumn(Name = "Skl 6", FieldIndex = 18)]
                public int Skl_6 { get; set; }
                [CsvColumn(Name = "Lvl 6", FieldIndex = 19)]
                public string Lvl_6 { get; set; }
                [CsvColumn(Name = "Skl 7", FieldIndex = 20)]
                public int Skl_7 { get; set; }
                [CsvColumn(Name = "Lvl 7", FieldIndex = 21)]
                public string Lvl_7 { get; set; }
                [CsvColumn(Name = "Skl 8", FieldIndex = 22)]
                public int Skl_8 { get; set; }
                [CsvColumn(Name = "Lvl 8", FieldIndex = 23)]
                public string Lvl_8 { get; set; }
                [CsvColumn(Name = "Skl 9", FieldIndex = 24)]
                public int Skl_9 { get; set; }
                [CsvColumn(Name = "Lvl 9", FieldIndex = 25)]
                public string Lvl_9 { get; set; }
                [CsvColumn(Name = "Skl 10", FieldIndex = 26)]
                public int Skl_10 { get; set; }
                [CsvColumn(Name = "Lvl 10", FieldIndex = 27)]
                public string Lvl_10 { get; set; }
                [CsvColumn(Name = "Skl 11", FieldIndex = 28)]
                public int Skl_11 { get; set; }
                [CsvColumn(Name = "Lvl 11", FieldIndex = 29)]
                public string Lvl_11 { get; set; }
                [CsvColumn(Name = "Skl 12", FieldIndex = 30)]
                public int Skl_12 { get; set; }
                [CsvColumn(Name = "Lvl 12", FieldIndex = 31)]
                public string Lvl_12 { get; set; }
                [CsvColumn(Name = "Skl 13", FieldIndex = 32)]
                public int Skl_13 { get; set; }
                [CsvColumn(Name = "Lvl 13", FieldIndex = 33)]
                public string Lvl_13 { get; set; }
                [CsvColumn(Name = "Skl 14", FieldIndex = 34)]
                public int Skl_14 { get; set; }
                [CsvColumn(Name = "Lvl 14", FieldIndex = 35)]
                public string Lvl_14 { get; set; }
                [CsvColumn(Name = "Skl 15", FieldIndex = 36)]
                public int Skl_15 { get; set; }
                [CsvColumn(Name = "Lvl 15", FieldIndex = 37)]
                public string Lvl_15 { get; set; }
                [CsvColumn(Name = "Skl 16", FieldIndex = 38)]
                public int Skl_16 { get; set; }
                [CsvColumn(Name = "Lvl 16", FieldIndex = 39)]
                public string Lvl_16 { get; set; }
                [CsvColumn(Name = "Skl 17", FieldIndex = 40)]
                public int Skl_17 { get; set; }
                [CsvColumn(Name = "Lvl 17", FieldIndex = 41)]
                public string Lvl_17 { get; set; }
                [CsvColumn(Name = "Skl 18", FieldIndex = 42)]
                public int Skl_18 { get; set; }
                [CsvColumn(Name = "Lvl 18", FieldIndex = 43)]
                public string Lvl_18 { get; set; }
                [CsvColumn(Name = "Skl 19", FieldIndex = 44)]
                public int Skl_19 { get; set; }
                [CsvColumn(Name = "Lvl 19", FieldIndex = 45)]
                public string Lvl_19 { get; set; }
                [CsvColumn(Name = "Skl 20", FieldIndex = 46)]
                public int Skl_20 { get; set; }
                [CsvColumn(Name = "Lvl 20", FieldIndex = 47)]
                public string Lvl_20 { get; set; }
                [CsvColumn(Name = "Skl 21", FieldIndex = 48)]
                public int Skl_21 { get; set; }
                [CsvColumn(Name = "Lvl 21", FieldIndex = 49)]
                public string Lvl_21 { get; set; }
                [CsvColumn(Name = "Skl 22", FieldIndex = 50)]
                public int Skl_22 { get; set; }
                [CsvColumn(Name = "Lvl 22", FieldIndex = 51)]
                public string Lvl_22 { get; set; }
                [CsvColumn(Name = "Skl 23", FieldIndex = 52)]
                public int Skl_23 { get; set; }
                [CsvColumn(Name = "Lvl 23", FieldIndex = 53)]
                public string Lvl_23 { get; set; }
                [CsvColumn(Name = "Skl 24", FieldIndex = 54)]
                public int Skl_24 { get; set; }
                [CsvColumn(Name = "Lvl 24", FieldIndex = 55)]
                public string Lvl_24 { get; set; }
                [CsvColumn(Name = "Skl 25", FieldIndex = 56)]
                public int Skl_25 { get; set; }
                [CsvColumn(Name = "Lvl 25", FieldIndex = 57)]
                public string Lvl_25 { get; set; }
                [CsvColumn(Name = "Skl 26", FieldIndex = 58)]
                public int Skl_26 { get; set; }
                [CsvColumn(Name = "Lvl 26", FieldIndex = 59)]
                public string Lvl_26 { get; set; }
                [CsvColumn(Name = "Skl 27", FieldIndex = 60)]
                public int Skl_27 { get; set; }
                [CsvColumn(Name = "Lvl 27", FieldIndex = 61)]
                public string Lvl_27 { get; set; }
                [CsvColumn(Name = "Skl 28", FieldIndex = 62)]
                public int Skl_28 { get; set; }
                [CsvColumn(Name = "Lvl 28", FieldIndex = 63)]
                public string Lvl_28 { get; set; }
                [CsvColumn(Name = "Skl 29", FieldIndex = 64)]
                public int Skl_29 { get; set; }
                [CsvColumn(Name = "Lvl 29", FieldIndex = 65)]
                public string Lvl_29 { get; set; }
                [CsvColumn(Name = "Skl 30", FieldIndex = 66)]
                public int Skl_30 { get; set; }
                [CsvColumn(Name = "Lvl 30", FieldIndex = 67)]
                public string Lvl_30 { get; set; }
                [CsvColumn(Name = "Skl 31", FieldIndex = 68)]
                public int Skl_31 { get; set; }
                [CsvColumn(Name = "Lvl 31", FieldIndex = 69)]
                public string Lvl_31 { get; set; }
                [CsvColumn(Name = "Skl 32", FieldIndex = 70)]
                public int Skl_32 { get; set; }
                [CsvColumn(Name = "Lvl 32", FieldIndex = 71)]
                public string Lvl_32 { get; set; }
                [CsvColumn(Name = "Skl 33", FieldIndex = 72)]
                public int Skl_33 { get; set; }
                [CsvColumn(Name = "Lvl 33", FieldIndex = 73)]
                public string Lvl_33 { get; set; }
                [CsvColumn(Name = "Skl 34", FieldIndex = 74)]
                public int Skl_34 { get; set; }
                [CsvColumn(Name = "Lvl 34", FieldIndex = 75)]
                public string Lvl_34 { get; set; }
                [CsvColumn(Name = "Skl 35", FieldIndex = 76)]
                public int Skl_35 { get; set; }
                [CsvColumn(Name = "Lvl 35", FieldIndex = 77)]
                public string Lvl_35 { get; set; }
                [CsvColumn(Name = "Skl 36", FieldIndex = 78)]
                public int Skl_36 { get; set; }
                [CsvColumn(Name = "Lvl 36", FieldIndex = 79)]
                public string Lvl_36 { get; set; }
                [CsvColumn(Name = "Skl 37", FieldIndex = 80)]
                public int Skl_37 { get; set; }
                [CsvColumn(Name = "Lvl 37", FieldIndex = 81)]
                public string Lvl_37 { get; set; }
                [CsvColumn(Name = "Skl 38", FieldIndex = 82)]
                public int Skl_38 { get; set; }
                [CsvColumn(Name = "Lvl 38", FieldIndex = 83)]
                public string Lvl_38 { get; set; }
                [CsvColumn(Name = "Skl 39", FieldIndex = 84)]
                public int Skl_39 { get; set; }
                [CsvColumn(Name = "Lvl 39", FieldIndex = 85)]
                public string Lvl_39 { get; set; }
                [CsvColumn(Name = "Skl 40", FieldIndex = 86)]
                public int Skl_40 { get; set; }
                [CsvColumn(Name = "Lvl 40", FieldIndex = 87)]
                public string Lvl_40 { get; set; }
                [CsvColumn(Name = "Skl 41", FieldIndex = 88)]
                public int Skl_41 { get; set; }
                [CsvColumn(Name = "Lvl 41", FieldIndex = 89)]
                public string Lvl_41 { get; set; }
                [CsvColumn(Name = "Skl 42", FieldIndex = 90)]
                public int Skl_42 { get; set; }
                [CsvColumn(Name = "Lvl 42", FieldIndex = 91)]
                public string Lvl_42 { get; set; }
                [CsvColumn(Name = "Skl 43", FieldIndex = 92)]
                public int Skl_43 { get; set; }
                [CsvColumn(Name = "Lvl 43", FieldIndex = 93)]
                public string Lvl_43 { get; set; }
                [CsvColumn(Name = "Skl 44", FieldIndex = 94)]
                public int Skl_44 { get; set; }
                [CsvColumn(Name = "Lvl 44", FieldIndex = 95)]
                public string Lvl_44 { get; set; }
                [CsvColumn(Name = "Skl 45", FieldIndex = 96)]
                public int Skl_45 { get; set; }
                [CsvColumn(Name = "Lvl 45", FieldIndex = 97)]
                public string Lvl_45 { get; set; }
                [CsvColumn(Name = "Skl 46", FieldIndex = 98)]
                public int Skl_46 { get; set; }
                [CsvColumn(Name = "Lvl 46", FieldIndex = 99)]
                public string Lvl_46 { get; set; }
                [CsvColumn(Name = "Skl 47", FieldIndex = 100)]
                public int Skl_47 { get; set; }
                [CsvColumn(Name = "Lvl 47", FieldIndex = 101)]
                public string Lvl_47 { get; set; }
                [CsvColumn(Name = "Skl 48", FieldIndex = 102)]
                public int Skl_48 { get; set; }
                [CsvColumn(Name = "Lvl 48", FieldIndex = 103)]
                public string Lvl_48 { get; set; }
                [CsvColumn(Name = "Skl 49", FieldIndex = 104)]
                public int Skl_49 { get; set; }
                [CsvColumn(Name = "Lvl 49", FieldIndex = 105)]
                public string Lvl_49 { get; set; }
                [CsvColumn(Name = "Skl 50", FieldIndex = 106)]
                public int Skl_50 { get; set; }
                [CsvColumn(Name = "Lvl 50", FieldIndex = 107)]
                public string Lvl_50 { get; set; }
                [CsvColumn(Name = "Skl 51", FieldIndex = 108)]
                public int Skl_51 { get; set; }
                [CsvColumn(Name = "Lvl 51", FieldIndex = 109)]
                public string Lvl_51 { get; set; }
                [CsvColumn(Name = "Skl 52", FieldIndex = 110)]
                public int Skl_52 { get; set; }
                [CsvColumn(Name = "Lvl 52", FieldIndex = 111)]
                public string Lvl_52 { get; set; }
                [CsvColumn(Name = "Skl 53", FieldIndex = 112)]
                public int Skl_53 { get; set; }
                [CsvColumn(Name = "Lvl 53", FieldIndex = 113)]
                public string Lvl_53 { get; set; }
                [CsvColumn(Name = "Skl 54", FieldIndex = 114)]
                public int Skl_54 { get; set; }
                [CsvColumn(Name = "Lvl 54", FieldIndex = 115)]
                public string Lvl_54 { get; set; }
                [CsvColumn(Name = "Skl 55", FieldIndex = 116)]
                public int Skl_55 { get; set; }
                [CsvColumn(Name = "Lvl 55", FieldIndex = 117)]
                public string Lvl_55 { get; set; }
                [CsvColumn(Name = "Skl 56", FieldIndex = 118)]
                public int Skl_56 { get; set; }
                [CsvColumn(Name = "Lvl 56", FieldIndex = 119)]
                public string Lvl_56 { get; set; }
                [CsvColumn(Name = "Skl 57", FieldIndex = 120)]
                public int Skl_57 { get; set; }
                [CsvColumn(Name = "Lvl 57", FieldIndex = 121)]
                public string Lvl_57 { get; set; }
                [CsvColumn(Name = "Skl 58", FieldIndex = 122)]
                public int Skl_58 { get; set; }
                [CsvColumn(Name = "Lvl 58", FieldIndex = 123)]
                public string Lvl_58 { get; set; }
                [CsvColumn(Name = "Skl 59", FieldIndex = 124)]
                public int Skl_59 { get; set; }
                [CsvColumn(Name = "Lvl 59", FieldIndex = 125)]
                public string Lvl_59 { get; set; }
                [CsvColumn(Name = "Skl 60", FieldIndex = 126)]
                public int Skl_60 { get; set; }
                [CsvColumn(Name = "Lvl 60", FieldIndex = 127)]
                public string Lvl_60 { get; set; }
                [CsvColumn(Name = "Skl 61", FieldIndex = 128)]
                public int Skl_61 { get; set; }
                [CsvColumn(Name = "Lvl 61", FieldIndex = 129)]
                public string Lvl_61 { get; set; }
                [CsvColumn(Name = "Skl 62", FieldIndex = 130)]
                public int Skl_62 { get; set; }
                [CsvColumn(Name = "Lvl 62", FieldIndex = 131)]
                public string Lvl_62 { get; set; }
                [CsvColumn(Name = "Skl 63", FieldIndex = 132)]
                public int Skl_63 { get; set; }
                [CsvColumn(Name = "Lvl 63", FieldIndex = 133)]
                public string Lvl_63 { get; set; }
                [CsvColumn(Name = "Skl 64", FieldIndex = 134)]
                public int Skl_64 { get; set; }
                [CsvColumn(Name = "Lvl 64", FieldIndex = 135)]
                public string Lvl_64 { get; set; }
                [CsvColumn(Name = "Skl 65", FieldIndex = 136)]
                public int Skl_65 { get; set; }
                [CsvColumn(Name = "Lvl 65", FieldIndex = 137)]
                public string Lvl_65 { get; set; }
                [CsvColumn(Name = "Skl 66", FieldIndex = 138)]
                public int Skl_66 { get; set; }
                [CsvColumn(Name = "Lvl 66", FieldIndex = 139)]
                public string Lvl_66 { get; set; }
                [CsvColumn(Name = "Skl 67", FieldIndex = 140)]
                public int Skl_67 { get; set; }
                [CsvColumn(Name = "Lvl 67", FieldIndex = 141)]
                public string Lvl_67 { get; set; }
                [CsvColumn(Name = "Skl 68", FieldIndex = 142)]
                public int Skl_68 { get; set; }
                [CsvColumn(Name = "Lvl 68", FieldIndex = 143)]
                public string Lvl_68 { get; set; }
                [CsvColumn(Name = "Skl 69", FieldIndex = 144)]
                public int Skl_69 { get; set; }
                [CsvColumn(Name = "Lvl 69", FieldIndex = 145)]
                public string Lvl_69 { get; set; }
                [CsvColumn(Name = "Skl 70", FieldIndex = 146)]
                public int Skl_70 { get; set; }
                [CsvColumn(Name = "Lvl 70", FieldIndex = 147)]
                public string Lvl_70 { get; set; }
                [CsvColumn(Name = "Skl 71", FieldIndex = 148)]
                public int Skl_71 { get; set; }
                [CsvColumn(Name = "Lvl 71", FieldIndex = 149)]
                public string Lvl_71 { get; set; }
                [CsvColumn(Name = "Skl 72", FieldIndex = 150)]
                public int Skl_72 { get; set; }
                [CsvColumn(Name = "Lvl 72", FieldIndex = 151)]
                public string Lvl_72 { get; set; }
                [CsvColumn(Name = "Skl 73", FieldIndex = 152)]
                public int Skl_73 { get; set; }
                [CsvColumn(Name = "Lvl 73", FieldIndex = 153)]
                public string Lvl_73 { get; set; }
                [CsvColumn(Name = "Skl 74", FieldIndex = 154)]
                public int Skl_74 { get; set; }
                [CsvColumn(Name = "Lvl 74", FieldIndex = 155)]
                public string Lvl_74 { get; set; }
                [CsvColumn(Name = "Skl 75", FieldIndex = 156)]
                public int Skl_75 { get; set; }
                [CsvColumn(Name = "Lvl 75", FieldIndex = 157)]
                public string Lvl_75 { get; set; }
                [CsvColumn(Name = "Skl 76", FieldIndex = 158)]
                public int Skl_76 { get; set; }
                [CsvColumn(Name = "Lvl 76", FieldIndex = 159)]
                public string Lvl_76 { get; set; }
                [CsvColumn(Name = "Skl 77", FieldIndex = 160)]
                public int Skl_77 { get; set; }
                [CsvColumn(Name = "Lvl 77", FieldIndex = 161)]
                public string Lvl_77 { get; set; }
                [CsvColumn(Name = "Skl 78", FieldIndex = 162)]
                public int Skl_78 { get; set; }
                [CsvColumn(Name = "Lvl 78", FieldIndex = 163)]
                public string Lvl_78 { get; set; }
                [CsvColumn(Name = "Skl 79", FieldIndex = 164)]
                public int Skl_79 { get; set; }
                [CsvColumn(Name = "Lvl 79", FieldIndex = 165)]
                public string Lvl_79 { get; set; }
                [CsvColumn(Name = "Skl 80", FieldIndex = 166)]
                public int Skl_80 { get; set; }
                [CsvColumn(Name = "Lvl 80", FieldIndex = 167)]
                public string Lvl_80 { get; set; }
                [CsvColumn(Name = "Skl 81", FieldIndex = 168)]
                public int Skl_81 { get; set; }
                [CsvColumn(Name = "Lvl 81", FieldIndex = 169)]
                public string Lvl_81 { get; set; }
                [CsvColumn(Name = "Skl 82", FieldIndex = 170)]
                public int Skl_82 { get; set; }
                [CsvColumn(Name = "Lvl 82", FieldIndex = 171)]
                public string Lvl_82 { get; set; }
                [CsvColumn(Name = "Skl 83", FieldIndex = 172)]
                public int Skl_83 { get; set; }
                [CsvColumn(Name = "Lvl 83", FieldIndex = 173)]
                public string Lvl_83 { get; set; }
                [CsvColumn(Name = "Skl 84", FieldIndex = 174)]
                public int Skl_84 { get; set; }
                [CsvColumn(Name = "Lvl 84", FieldIndex = 175)]
                public string Lvl_84 { get; set; }
                [CsvColumn(Name = "Skl 85", FieldIndex = 176)]
                public int Skl_85 { get; set; }
                [CsvColumn(Name = "Lvl 85", FieldIndex = 177)]
                public string Lvl_85 { get; set; }
                [CsvColumn(Name = "Skl 86", FieldIndex = 178)]
                public int Skl_86 { get; set; }
                [CsvColumn(Name = "Lvl 86", FieldIndex = 179)]
                public string Lvl_86 { get; set; }
                [CsvColumn(Name = "Skl 87", FieldIndex = 180)]
                public int Skl_87 { get; set; }
                [CsvColumn(Name = "Lvl 87", FieldIndex = 181)]
                public string Lvl_87 { get; set; }
                [CsvColumn(Name = "Skl 88", FieldIndex = 182)]
                public int Skl_88 { get; set; }
                [CsvColumn(Name = "Lvl 88", FieldIndex = 183)]
                public string Lvl_88 { get; set; }
                [CsvColumn(Name = "Skl 89", FieldIndex = 184)]
                public int Skl_89 { get; set; }
                [CsvColumn(Name = "Lvl 89", FieldIndex = 185)]
                public string Lvl_89 { get; set; }
                [CsvColumn(Name = "Skl 90", FieldIndex = 186)]
                public int Skl_90 { get; set; }
                [CsvColumn(Name = "Lvl 90", FieldIndex = 187)]
                public string Lvl_90 { get; set; }
                [CsvColumn(Name = "Skl 91", FieldIndex = 188)]
                public int Skl_91 { get; set; }
                [CsvColumn(Name = "Lvl 91", FieldIndex = 189)]
                public string Lvl_91 { get; set; }
                [CsvColumn(Name = "Skl 92", FieldIndex = 190)]
                public int Skl_92 { get; set; }
                [CsvColumn(Name = "Lvl 92", FieldIndex = 191)]
                public string Lvl_92 { get; set; }
                [CsvColumn(Name = "Skl 93", FieldIndex = 192)]
                public int Skl_93 { get; set; }
                [CsvColumn(Name = "Lvl 93", FieldIndex = 193)]
                public string Lvl_93 { get; set; }
                [CsvColumn(Name = "Skl 94", FieldIndex = 194)]
                public int Skl_94 { get; set; }
                [CsvColumn(Name = "Lvl 94", FieldIndex = 195)]
                public string Lvl_94 { get; set; }
                [CsvColumn(Name = "Skl 95", FieldIndex = 196)]
                public int Skl_95 { get; set; }
                [CsvColumn(Name = "Lvl 95", FieldIndex = 197)]
                public string Lvl_95 { get; set; }
                [CsvColumn(Name = "Skl 96", FieldIndex = 198)]
                public int Skl_96 { get; set; }
                [CsvColumn(Name = "Lvl 96", FieldIndex = 199)]
                public string Lvl_96 { get; set; }
                [CsvColumn(Name = "Skl 97", FieldIndex = 200)]
                public int Skl_97 { get; set; }
                [CsvColumn(Name = "Lvl 97", FieldIndex = 201)]
                public string Lvl_97 { get; set; }
                [CsvColumn(Name = "Skl 98", FieldIndex = 202)]
                public int Skl_98 { get; set; }
                [CsvColumn(Name = "Lvl 98", FieldIndex = 203)]
                public string Lvl_98 { get; set; }
                [CsvColumn(Name = "Skl 99", FieldIndex = 204)]
                public int Skl_99 { get; set; }
                [CsvColumn(Name = "Lvl 99", FieldIndex = 205)]
                public string Lvl_99 { get; set; }
                [CsvColumn(Name = "Skl 100", FieldIndex = 206)]
                public int Skl_100 { get; set; }
                [CsvColumn(Name = "Lvl 100", FieldIndex = 207)]
                public string Lvl_100 { get; set; }
                [CsvColumn(Name = "Skl 101", FieldIndex = 208)]
                public int Skl_101 { get; set; }
                [CsvColumn(Name = "Lvl 101", FieldIndex = 209)]
                public string Lvl_101 { get; set; }
                [CsvColumn(Name = "Skl 102", FieldIndex = 210)]
                public int Skl_102 { get; set; }
                [CsvColumn(Name = "Lvl 102", FieldIndex = 211)]
                public string Lvl_102 { get; set; }
                [CsvColumn(Name = "Skl 103", FieldIndex = 212)]
                public int Skl_103 { get; set; }
                [CsvColumn(Name = "Lvl 103", FieldIndex = 213)]
                public string Lvl_103 { get; set; }
                [CsvColumn(Name = "Skl 104", FieldIndex = 214)]
                public int Skl_104 { get; set; }
                [CsvColumn(Name = "Lvl 104", FieldIndex = 215)]
                public string Lvl_104 { get; set; }
                [CsvColumn(Name = "Skl 105", FieldIndex = 216)]
                public int Skl_105 { get; set; }
                [CsvColumn(Name = "Lvl 105", FieldIndex = 217)]
                public string Lvl_105 { get; set; }
                [CsvColumn(Name = "Skl 106", FieldIndex = 218)]
                public int Skl_106 { get; set; }
                [CsvColumn(Name = "Lvl 106", FieldIndex = 219)]
                public string Lvl_106 { get; set; }
                [CsvColumn(Name = "Skl 107", FieldIndex = 220)]
                public int Skl_107 { get; set; }
                [CsvColumn(Name = "Lvl 107", FieldIndex = 221)]
                public string Lvl_107 { get; set; }
                [CsvColumn(Name = "Skl 108", FieldIndex = 222)]
                public int Skl_108 { get; set; }
                [CsvColumn(Name = "Lvl 108", FieldIndex = 223)]
                public string Lvl_108 { get; set; }
                [CsvColumn(Name = "Skl 109", FieldIndex = 224)]
                public int Skl_109 { get; set; }
                [CsvColumn(Name = "Lvl 109", FieldIndex = 225)]
                public string Lvl_109 { get; set; }
                [CsvColumn(Name = "Skl 110", FieldIndex = 226)]
                public int Skl_110 { get; set; }
                [CsvColumn(Name = "Lvl 110", FieldIndex = 227)]
                public string Lvl_110 { get; set; }
                [CsvColumn(Name = "Skl 111", FieldIndex = 228)]
                public int Skl_111 { get; set; }
                [CsvColumn(Name = "Lvl 111", FieldIndex = 229)]
                public string Lvl_111 { get; set; }
                [CsvColumn(Name = "Skl 112", FieldIndex = 230)]
                public int Skl_112 { get; set; }
                [CsvColumn(Name = "Lvl 112", FieldIndex = 231)]
                public string Lvl_112 { get; set; }
                [CsvColumn(Name = "Skl 113", FieldIndex = 232)]
                public int Skl_113 { get; set; }
                [CsvColumn(Name = "Lvl 113", FieldIndex = 233)]
                public string Lvl_113 { get; set; }
                [CsvColumn(Name = "Skl 114", FieldIndex = 234)]
                public int Skl_114 { get; set; }
                [CsvColumn(Name = "Lvl 114", FieldIndex = 235)]
                public string Lvl_114 { get; set; }
                [CsvColumn(Name = "Skl 115", FieldIndex = 236)]
                public int Skl_115 { get; set; }
                [CsvColumn(Name = "Lvl 115", FieldIndex = 237)]
                public string Lvl_115 { get; set; }
                [CsvColumn(Name = "Skl 116", FieldIndex = 238)]
                public int Skl_116 { get; set; }
                [CsvColumn(Name = "Lvl 116", FieldIndex = 239)]
                public string Lvl_116 { get; set; }
                [CsvColumn(Name = "Skl 117", FieldIndex = 240)]
                public int Skl_117 { get; set; }
                [CsvColumn(Name = "Lvl 117", FieldIndex = 241)]
                public string Lvl_117 { get; set; }
                [CsvColumn(Name = "Skl 118", FieldIndex = 242)]
                public int Skl_118 { get; set; }
                [CsvColumn(Name = "Lvl 118", FieldIndex = 243)]
                public string Lvl_118 { get; set; }
                [CsvColumn(Name = "Skl 119", FieldIndex = 244)]
                public int Skl_119 { get; set; }
                [CsvColumn(Name = "Lvl 119", FieldIndex = 245)]
                public string Lvl_119 { get; set; }
                [CsvColumn(Name = "Skl 120", FieldIndex = 246)]
                public int Skl_120 { get; set; }
                [CsvColumn(Name = "Lvl 120", FieldIndex = 247)]
                public string Lvl_120 { get; set; }
            #endregion
    #endregion

    #region Public access functions
        //cheaper to bulk process from here
        public SkillPriority[] AssignedSkills()
                {
                    //Order of occurence is important as it signals users making changes to assignments, even if the change has the same effect as before.
                    SkillPriority[] tmp = new SkillPriority[120];

                    tmp[0] = new SkillPriority() { Skill_ID = Skl_1, Priority = Lvl_1 };
                    tmp[1] = new SkillPriority() { Skill_ID = Skl_2, Priority = Lvl_2 };
                    tmp[2] = new SkillPriority() { Skill_ID = Skl_3, Priority = Lvl_3 };
                    tmp[3] = new SkillPriority() { Skill_ID = Skl_4, Priority = Lvl_4 };
                    tmp[4] = new SkillPriority() { Skill_ID = Skl_5, Priority = Lvl_5 };
                    tmp[5] = new SkillPriority() { Skill_ID = Skl_6, Priority = Lvl_6 };
                    tmp[6] = new SkillPriority() { Skill_ID = Skl_7, Priority = Lvl_7 };
                    tmp[7] = new SkillPriority() { Skill_ID = Skl_8, Priority = Lvl_8 };
                    tmp[8] = new SkillPriority() { Skill_ID = Skl_9, Priority = Lvl_9 };
                    tmp[9] = new SkillPriority() { Skill_ID = Skl_10, Priority = Lvl_10 };
                    tmp[10] = new SkillPriority() { Skill_ID = Skl_11, Priority = Lvl_11 };
                    tmp[11] = new SkillPriority() { Skill_ID = Skl_12, Priority = Lvl_12 };
                    tmp[12] = new SkillPriority() { Skill_ID = Skl_13, Priority = Lvl_13 };
                    tmp[13] = new SkillPriority() { Skill_ID = Skl_14, Priority = Lvl_14 };
                    tmp[14] = new SkillPriority() { Skill_ID = Skl_15, Priority = Lvl_15 };
                    tmp[15] = new SkillPriority() { Skill_ID = Skl_16, Priority = Lvl_16 };
                    tmp[16] = new SkillPriority() { Skill_ID = Skl_17, Priority = Lvl_17 };
                    tmp[17] = new SkillPriority() { Skill_ID = Skl_18, Priority = Lvl_18 };
                    tmp[18] = new SkillPriority() { Skill_ID = Skl_19, Priority = Lvl_19 };
                    tmp[19] = new SkillPriority() { Skill_ID = Skl_20, Priority = Lvl_20 };
                    tmp[20] = new SkillPriority() { Skill_ID = Skl_21, Priority = Lvl_21 };
                    tmp[21] = new SkillPriority() { Skill_ID = Skl_22, Priority = Lvl_22 };
                    tmp[22] = new SkillPriority() { Skill_ID = Skl_23, Priority = Lvl_23 };
                    tmp[23] = new SkillPriority() { Skill_ID = Skl_24, Priority = Lvl_24 };
                    tmp[24] = new SkillPriority() { Skill_ID = Skl_25, Priority = Lvl_25 };
                    tmp[25] = new SkillPriority() { Skill_ID = Skl_26, Priority = Lvl_26 };
                    tmp[26] = new SkillPriority() { Skill_ID = Skl_27, Priority = Lvl_27 };
                    tmp[27] = new SkillPriority() { Skill_ID = Skl_28, Priority = Lvl_28 };
                    tmp[28] = new SkillPriority() { Skill_ID = Skl_29, Priority = Lvl_29 };
                    tmp[29] = new SkillPriority() { Skill_ID = Skl_30, Priority = Lvl_30 };
                    tmp[30] = new SkillPriority() { Skill_ID = Skl_31, Priority = Lvl_31 };
                    tmp[31] = new SkillPriority() { Skill_ID = Skl_32, Priority = Lvl_32 };
                    tmp[32] = new SkillPriority() { Skill_ID = Skl_33, Priority = Lvl_33 };
                    tmp[33] = new SkillPriority() { Skill_ID = Skl_34, Priority = Lvl_34 };
                    tmp[34] = new SkillPriority() { Skill_ID = Skl_35, Priority = Lvl_35 };
                    tmp[35] = new SkillPriority() { Skill_ID = Skl_36, Priority = Lvl_36 };
                    tmp[36] = new SkillPriority() { Skill_ID = Skl_37, Priority = Lvl_37 };
                    tmp[37] = new SkillPriority() { Skill_ID = Skl_38, Priority = Lvl_38 };
                    tmp[38] = new SkillPriority() { Skill_ID = Skl_39, Priority = Lvl_39 };
                    tmp[39] = new SkillPriority() { Skill_ID = Skl_40, Priority = Lvl_40 };
                    tmp[40] = new SkillPriority() { Skill_ID = Skl_41, Priority = Lvl_41 };
                    tmp[41] = new SkillPriority() { Skill_ID = Skl_42, Priority = Lvl_42 };
                    tmp[42] = new SkillPriority() { Skill_ID = Skl_43, Priority = Lvl_43 };
                    tmp[43] = new SkillPriority() { Skill_ID = Skl_44, Priority = Lvl_44 };
                    tmp[44] = new SkillPriority() { Skill_ID = Skl_45, Priority = Lvl_45 };
                    tmp[45] = new SkillPriority() { Skill_ID = Skl_46, Priority = Lvl_46 };
                    tmp[46] = new SkillPriority() { Skill_ID = Skl_47, Priority = Lvl_47 };
                    tmp[47] = new SkillPriority() { Skill_ID = Skl_48, Priority = Lvl_48 };
                    tmp[48] = new SkillPriority() { Skill_ID = Skl_49, Priority = Lvl_49 };
                    tmp[49] = new SkillPriority() { Skill_ID = Skl_50, Priority = Lvl_50 };
                    tmp[50] = new SkillPriority() { Skill_ID = Skl_51, Priority = Lvl_51 };
                    tmp[51] = new SkillPriority() { Skill_ID = Skl_52, Priority = Lvl_52 };
                    tmp[52] = new SkillPriority() { Skill_ID = Skl_53, Priority = Lvl_53 };
                    tmp[53] = new SkillPriority() { Skill_ID = Skl_54, Priority = Lvl_54 };
                    tmp[54] = new SkillPriority() { Skill_ID = Skl_55, Priority = Lvl_55 };
                    tmp[55] = new SkillPriority() { Skill_ID = Skl_56, Priority = Lvl_56 };
                    tmp[56] = new SkillPriority() { Skill_ID = Skl_57, Priority = Lvl_57 };
                    tmp[57] = new SkillPriority() { Skill_ID = Skl_58, Priority = Lvl_58 };
                    tmp[58] = new SkillPriority() { Skill_ID = Skl_59, Priority = Lvl_59 };
                    tmp[59] = new SkillPriority() { Skill_ID = Skl_60, Priority = Lvl_60 };
                    tmp[60] = new SkillPriority() { Skill_ID = Skl_61, Priority = Lvl_61 };
                    tmp[61] = new SkillPriority() { Skill_ID = Skl_62, Priority = Lvl_62 };
                    tmp[62] = new SkillPriority() { Skill_ID = Skl_63, Priority = Lvl_63 };
                    tmp[63] = new SkillPriority() { Skill_ID = Skl_64, Priority = Lvl_64 };
                    tmp[64] = new SkillPriority() { Skill_ID = Skl_65, Priority = Lvl_65 };
                    tmp[65] = new SkillPriority() { Skill_ID = Skl_66, Priority = Lvl_66 };
                    tmp[66] = new SkillPriority() { Skill_ID = Skl_67, Priority = Lvl_67 };
                    tmp[67] = new SkillPriority() { Skill_ID = Skl_68, Priority = Lvl_68 };
                    tmp[68] = new SkillPriority() { Skill_ID = Skl_69, Priority = Lvl_69 };
                    tmp[69] = new SkillPriority() { Skill_ID = Skl_70, Priority = Lvl_70 };
                    tmp[70] = new SkillPriority() { Skill_ID = Skl_71, Priority = Lvl_71 };
                    tmp[71] = new SkillPriority() { Skill_ID = Skl_72, Priority = Lvl_72 };
                    tmp[72] = new SkillPriority() { Skill_ID = Skl_73, Priority = Lvl_73 };
                    tmp[73] = new SkillPriority() { Skill_ID = Skl_74, Priority = Lvl_74 };
                    tmp[74] = new SkillPriority() { Skill_ID = Skl_75, Priority = Lvl_75 };
                    tmp[75] = new SkillPriority() { Skill_ID = Skl_76, Priority = Lvl_76 };
                    tmp[76] = new SkillPriority() { Skill_ID = Skl_77, Priority = Lvl_77 };
                    tmp[77] = new SkillPriority() { Skill_ID = Skl_78, Priority = Lvl_78 };
                    tmp[78] = new SkillPriority() { Skill_ID = Skl_79, Priority = Lvl_79 };
                    tmp[79] = new SkillPriority() { Skill_ID = Skl_80, Priority = Lvl_80 };
                    tmp[80] = new SkillPriority() { Skill_ID = Skl_81, Priority = Lvl_81 };
                    tmp[81] = new SkillPriority() { Skill_ID = Skl_82, Priority = Lvl_82 };
                    tmp[82] = new SkillPriority() { Skill_ID = Skl_83, Priority = Lvl_83 };
                    tmp[83] = new SkillPriority() { Skill_ID = Skl_84, Priority = Lvl_84 };
                    tmp[84] = new SkillPriority() { Skill_ID = Skl_85, Priority = Lvl_85 };
                    tmp[85] = new SkillPriority() { Skill_ID = Skl_86, Priority = Lvl_86 };
                    tmp[86] = new SkillPriority() { Skill_ID = Skl_87, Priority = Lvl_87 };
                    tmp[87] = new SkillPriority() { Skill_ID = Skl_88, Priority = Lvl_88 };
                    tmp[88] = new SkillPriority() { Skill_ID = Skl_89, Priority = Lvl_89 };
                    tmp[89] = new SkillPriority() { Skill_ID = Skl_90, Priority = Lvl_90 };
                    tmp[90] = new SkillPriority() { Skill_ID = Skl_91, Priority = Lvl_91 };
                    tmp[91] = new SkillPriority() { Skill_ID = Skl_92, Priority = Lvl_92 };
                    tmp[92] = new SkillPriority() { Skill_ID = Skl_93, Priority = Lvl_93 };
                    tmp[93] = new SkillPriority() { Skill_ID = Skl_94, Priority = Lvl_94 };
                    tmp[94] = new SkillPriority() { Skill_ID = Skl_95, Priority = Lvl_95 };
                    tmp[95] = new SkillPriority() { Skill_ID = Skl_96, Priority = Lvl_96 };
                    tmp[96] = new SkillPriority() { Skill_ID = Skl_97, Priority = Lvl_97 };
                    tmp[97] = new SkillPriority() { Skill_ID = Skl_98, Priority = Lvl_98 };
                    tmp[98] = new SkillPriority() { Skill_ID = Skl_99, Priority = Lvl_99 };
                    tmp[99] = new SkillPriority() { Skill_ID = Skl_100, Priority = Lvl_100 };
                    tmp[100] = new SkillPriority() { Skill_ID = Skl_101, Priority = Lvl_101 };
                    tmp[101] = new SkillPriority() { Skill_ID = Skl_102, Priority = Lvl_102 };
                    tmp[102] = new SkillPriority() { Skill_ID = Skl_103, Priority = Lvl_103 };
                    tmp[103] = new SkillPriority() { Skill_ID = Skl_104, Priority = Lvl_104 };
                    tmp[104] = new SkillPriority() { Skill_ID = Skl_105, Priority = Lvl_105 };
                    tmp[105] = new SkillPriority() { Skill_ID = Skl_106, Priority = Lvl_106 };
                    tmp[106] = new SkillPriority() { Skill_ID = Skl_107, Priority = Lvl_107 };
                    tmp[107] = new SkillPriority() { Skill_ID = Skl_108, Priority = Lvl_108 };
                    tmp[108] = new SkillPriority() { Skill_ID = Skl_109, Priority = Lvl_109 };
                    tmp[109] = new SkillPriority() { Skill_ID = Skl_110, Priority = Lvl_110 };
                    tmp[110] = new SkillPriority() { Skill_ID = Skl_111, Priority = Lvl_111 };
                    tmp[111] = new SkillPriority() { Skill_ID = Skl_112, Priority = Lvl_112 };
                    tmp[112] = new SkillPriority() { Skill_ID = Skl_113, Priority = Lvl_113 };
                    tmp[113] = new SkillPriority() { Skill_ID = Skl_114, Priority = Lvl_114 };
                    tmp[114] = new SkillPriority() { Skill_ID = Skl_115, Priority = Lvl_115 };
                    tmp[115] = new SkillPriority() { Skill_ID = Skl_116, Priority = Lvl_116 };
                    tmp[116] = new SkillPriority() { Skill_ID = Skl_117, Priority = Lvl_117 };
                    tmp[117] = new SkillPriority() { Skill_ID = Skl_118, Priority = Lvl_118 };
                    tmp[118] = new SkillPriority() { Skill_ID = Skl_119, Priority = Lvl_119 };
                    tmp[119] = new SkillPriority() { Skill_ID = Skl_120, Priority = Lvl_120 };



                    return tmp;

                }

        //Used for naive sequential equality comparison
        public string AssignedSkillsString()
                {
                    StringBuilder tmp = new StringBuilder();

                    foreach (SkillPriority item in AssignedSkills())
                    {
                        if (item.Skill_ID > 0)
                        {
                            tmp.Append(item.Skill_ID.ToString() + ":" + item.Priority + ",");
                        }
                    }

                    return tmp.ToString();
                }
    #endregion

    }
}
