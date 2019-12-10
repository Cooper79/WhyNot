using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_11
{
    class Hospital
    {
        public void MRT(Patient patient)
        {
            patient.MRT = true;
        }

        public void KT(Patient patient)
        {
            patient.KT = true;
        }

        public void Rentgen(Patient patient)
        {
            patient.Rentgen = true;
        }

        public void LOR(Patient patient)
        {
            patient.LOR = true;
        }

        public void UZI(Patient patient)
        {
            patient.UZI = true;
        }

        public void R_Test(Patient patient)
        {
            patient.R_Test = true;
        }

    }

    class Patient
    {
        public bool MRT { get; set; }

        public bool KT { get; set; }

        public bool Rentgen { get; set; }

        public bool LOR { get; set; }

        public bool UZI { get; set; }

        public bool R_Test { get; set; }

        public void OUT()
        {
            Console.WriteLine($"MRT: {(MRT ? "done" : "undone")}");

            Console.WriteLine($"KT: {(KT ? "done" : "undone")}");

            Console.WriteLine($"Rentgen: {(Rentgen ? "done" : "undone")}");

            Console.WriteLine($"LOR: {(LOR ? "done" : "undone")}");

            Console.WriteLine($"UZI: {(UZI ? "done" : "undone")}");

            Console.WriteLine($"R_test: {(R_Test ? "done" : "undone")}");
        }
    }

    class Program
    {
        public delegate void Delegate(Patient patient);
        
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            Patient patient = new Patient();

            Delegate Analises = null;
            Delegate MRT = new Delegate(hospital.MRT);
            Analises += MRT;
            Delegate KT = new Delegate(hospital.KT);
            Analises += KT;
            Delegate Rentgen = new Delegate(hospital.Rentgen);
            Analises += Rentgen;
            Delegate LOR = new Delegate(hospital.LOR);
            Analises += LOR;
            Delegate UZI = new Delegate(hospital.UZI);
            Analises += UZI;
            Delegate R_Test = new Delegate(hospital.R_Test);
            Analises += R_Test;

            Analises(patient);

            patient.OUT();
            Console.ReadKey();
        }
    }
}
