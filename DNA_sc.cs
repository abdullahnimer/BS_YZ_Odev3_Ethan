using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_sc
{
    List<int> genes=new List<int>(); //DNA uzunluk bilgisi saklanacak
    int dnaLength=0, maxValue=0;
    // constructing
    public DNA_sc(int dna_Length, int max_Value)
    {
        this.dnaLength = dna_Length;
        this.maxValue = max_Value;
        SetRandom();
    }
    public void SetRandom(){ //Rastgele içerikte DNA değerlerini belirir
        genes.Clear();  // Eski değerleri temizle
        for (int i = 0; i < dnaLength; i++)
        {
            genes.Add(Random.Range(0, maxValue)); // 0 ile max değer arasında rastgele sayı üret
        }
    }
    public void Mutate() {// stenen lokasyondaki genetik bilgiyi getiren fonksiyonu  tanımlar
        genes[Random.Range(0, dnaLength)] = Random.Range(0, maxValue); //
    }

    public void SetInt(int pos, int value){//DNA konumunda değer güncelleme fonksiyonu
        genes[pos] = value; // İlk değer olarak değer ata
    }
    public int GetGene(int pos){ // DNA konumunda değer okuma fonksiyonu
        return genes[pos]; // İlk değer olarak konumu döndür
    }

    public void Combine(DNA_sc d1,DNA_sc d2){//İki DNA kodunu (yarısı farklı ebeveynlerden gelecek  şekilde) birleştiren fonksiyonu tanımlar
        for (int i=0;i< dnaLength;i++){
                if(i< dnaLength/2.0)// int c=d1.genes[i]   
                 {
                    int c=d1.genes[i];
                  genes[i] = c;
                 }else
                 {
                    int c=d2.genes[i];
                  genes[i] = c;
                 }
        }
    }
    // Start is called before the first frame update
  
}
