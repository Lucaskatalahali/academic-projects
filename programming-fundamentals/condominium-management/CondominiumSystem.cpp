/***********************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2024-2025 BAHAR DÖNEMİ
**	
**				PROJE NUMARASI.......: 1
**				ÖĞRENCİ ADI..........: LUCAS ISAAC CASSOMA KATALAHALI
**				ÖĞRENCİ NUMARASI.....: 
**              DERSİN ALINDIĞI GRUP.: A
************************************************************************/
#include<iostream>
#include<string>
#include<iomanip>
#include<fstream>
using namespace std;

//Mekân sınıfı oluşturalım
class Mekan{

};

//Mekan sınıfından Daire sınıfı oluşturalım
class Daire: public Mekan{
private:
    bool daire_durum[90]; // En fazla 90 dairenin durumunu (doğru veya yanlış) saklamak için dizi
    int daire_id[90]; // Dairelerin ID'lerini saklamak için dizi
    int total_daire; // Her blok için toplam daire sayısı
    
public:
    Daire() : total_daire(0) { } 

    Daire(int blok){ //Dairelerin ID'leri oluşturma ve bunları true (mevcut) olarak başlatma fonksiyonu
        total_daire = 0;    
        //Aşağıdaki döngü her Blok (Bina) için 90 daire oluşturur. 0 ile biten numaralar çıkarılır
        for(int j = 1; j <= 99; j++){
            if((blok*100 + j)%10 == 0)
                continue; // 0 ile biten numaralar çıkarılır
            daire_id[total_daire] = blok*100 + j;
            daire_durum[total_daire] = true;
            total_daire++;
        }
    };

    int getDaire_durum(){ //Yeni kayıt için müsait daire olup olmadığını analiz eden fonksiyon
        for(int i = 0; i < total_daire; i++){
            if(daire_durum[i]){
                daire_durum[i] = false; //Daireyi dolu olarak birakmak
                return daire_id[i]; //Daire numarasını göndermek
            }    
        }
        cout<<"Mevcut Daire Yok\n";
        return 0; //Yeni bir oturan kaydedilemediğini belirtmek için sıfır döndür
    }
    //Verilen ID'nin geçerli ve dolu olup olmadığını kontrol eden Fonksiyon
    int daireBosalt(int id){ 
        for(int i = 0; i < total_daire; i++){
            if(daire_id[i] == id){
                if(!daire_durum[i]){// Eğer daire doluysa (false) aşağıdaki satırda boş olarak (true) bırak
                    daire_durum[i] = true;
                    return daire_id[i];
                }else{
                    return 1; //Apartman boşsa 1 döndür
                }
            }
        }
        return 0; //Geçersiz apartman (ID) ise sıfır döndür
    }

    // Verilen ID'nin geçerli ve dolu olup olmadığını kontrol eden Fonksiyon
    int duzeltme(int id){ 
        for(int i = 0; i < total_daire; i++){
            if(daire_id[i] == id){
                if(!daire_durum[i]){
                    return daire_id[i];
                }else{
                    return 1; // Daire boşsa 1 döndür
                }
            }
        }
        return 0; //Geçersiz apartman (ID) ise sıfır döndür
    }
};

//Mekân sınıfından Fitness sınıfı oluşturalım
class Fitness: public Mekan{
public:
    void sporSalonuKullanma(string adi, int id, int blok, float sonuc){
    ofstream fileFitness("Fitness.txt", ios::app);
    if(sonuc > 0){ //Bu, borç olduğunu gösterir
        cout<<"kullandirilmadi\n";
        if(fileFitness.is_open()){
            fileFitness<<left<< setw(39)<<adi<<setw(30)<<id<<setw(27)<<blok + 1 <<setw(27)<<"kullandirilmadi"<<endl;
            fileFitness.close();
        }
    }else{
        cout<<"kullandirildi\n";
        if(fileFitness.is_open()){
            fileFitness<<left<< setw(39)<<adi<<setw(30)<<id<<setw(27)<<blok + 1<<setw(27)<<"kullandirildi"<<endl;
            fileFitness.close();
        }
    } 
}
};

//Mekân sınıfından havuz sınıfı oluşturalım
class Havuz : public Mekan{
public:
    void havuzKul(string adi, int id, int blok, float sonuc){
        ofstream fileHavuz("HavuzKul.txt", ios::app);
        if(sonuc > 0){ //Bu, borç olduğunu gösterir
            cout<<"kullandirilmadi\n";
            if(fileHavuz.is_open()){
                fileHavuz<<left<< setw(39)<<adi<<setw(30)<<id<<setw(27)<<blok + 1 <<setw(27)<<"kullandirilmadi"<<endl;
                fileHavuz.close();
            }
        }else{
            cout<<"kullandirildi\n";
            if(fileHavuz.is_open()){
                fileHavuz<<left<< setw(39)<<adi<<setw(30)<<id<<setw(27)<<blok + 1<<setw(27)<<"kullandirildi"<<endl;
                fileHavuz.close();
            }
        } 
    }
};

//Oturan sınıfı oluşturalım
class Oturan{

};

//Oturan sınıfından AileReisi sınıfı oluşturalım.
class AileReisi: public Oturan{
private:
string adi;
int oturan_id;
string akrabalar[3];
float odeme;

public:
    AileReisi() : oturan_id(-1){
        adi = ""; //ID'leri -1 ve adları boş olarak başlatma
        for(int i = 0; i < 3; i++) {
            akrabalar[i] = "";
        }
    }
    void ekleme(int id, int kontrol){
        oturan_id = id;
        int akrabaSayi;
        cout<<"\t*Oturan Kayit*\n\n";
        cout<<"AileReisinin adi: ";
        cin.ignore();
        getline(cin, adi);
        cout<<"Aile Uyesi Sayisi: ";
        cin>> akrabaSayi; 
        while(akrabaSayi < 0 || akrabaSayi > 3){
            cout<<"Secenek 0 - 3 arasinda olmalidir! Tekrar deneyin..."<<endl;
            cout<<"Bir secenek secin: ";
            cin>> akrabaSayi;
        }
     
        for (int i = 0; i < 3; i++) {
            akrabalar[i].clear();
        }
            cin.ignore();
            for(int i = 0; i < akrabaSayi; i++){
                cout<<"Adi: ";
                getline(cin, akrabalar[i]);  
        }
        oturaniDosyayaKaydet(adi, oturan_id, akrabaSayi);

        if(kontrol == 1 ){ //Bu koşul, yeni bir oturan kaydederken ödeme yapılması gerektiğini gösterir
            cout<<"\nToplam odenecek tutar: "<<15000<<" TL"<<endl;
            cout<<"Odeme yapma: ";
            cin>> odeme;
            while(odeme < 0){
            cout<<"Odeme para negatif olmamalidir! Tekrar deneyin..."<<endl;
            cout<<"Odeme yapma: ";
            cin>> odeme;
            }
            //Değişiklik yapmadan önce ödemeyi dosyaya yazma
            {
                ofstream fileOdeme("Odeme.txt", ios::app);
                if(fileOdeme.is_open()){
                    fileOdeme << left << setw(24) <<id<< setw(24) << id/100 <<setw(24)<<fixed<<setprecision(2)<<odeme<<setw(24);
                    fileOdeme.close();
                }
            }
            
            odeme = 15000 - odeme; //Borç hesaplamak
            if(odeme < 0)
            odeme = 0.0f;

            {
                ofstream fileOdeme("Odeme.txt", ios::app);
                if(fileOdeme.is_open()){
                    fileOdeme<<fixed<<setprecision(2)<<odeme<<endl;
                    fileOdeme.close();
                }
            }
            cout<<"Yeni Oturan kaydedildi ve dosyaya kaydedildi.\nApartman ID: "<<oturan_id<<endl;

        }else{ //Eğer kontrol değişkeni sıfırsa (bu, sadece oturan bilgilerini düzelttiğimizi gösterir) ödeme yapılmayacak
            cout<<"Oturan bilgileri basariyla duzeltildi\n";
        }
    }

    void oturaniDosyayaKaydet(const string& oturanAdi, int daireId, int akrabaSayi){
        ofstream fileData("Data.txt", ios::app);
        if(fileData.is_open()){
            fileData<<left<< setw(40)<<oturanAdi<<setw(15)<<daireId<<setw(13)<<daireId/100<<setw(15)<<akrabaSayi<<endl;
            fileData.close();
        }
    }
    float akrabalarBul(string adi){
        for(const string& akraba: akrabalar){
            if(adi == akraba || adi == this -> adi)
                return odeme; //Adı bulursanız, ödeme durumunu döndürün
        }
        return -1; //Eğer eşleşen bir oturan bulunmazsa
    }
    int getOturan_id() const{
        return oturan_id;
    }
    float getOdeme() const{
        return odeme;
    }
    void setOdeme(float odeme){
        this -> odeme = odeme;
    }

    void odemeyapmak(){
        float yeniOdeme;
        if(odeme == 0){
            cout<<"Borc: 0.0 TL\nOturanin Borcu yok...";
        }else{
            cout<<"Borc: "<<odeme<<" TL"<<endl;
            cout<<"Odeme Yapma: ";
            cin>>yeniOdeme;
            while(yeniOdeme < 0){
            cout<<"Odeme para negatif olmamalidir! Tekrar deneyin..."<<endl;
            cout<<"Odeme yapma: ";
            cin>> yeniOdeme;
            }
            
            if(odeme - yeniOdeme < 0){
                odeme = 0.0f; 
            }else{
                odeme = odeme - yeniOdeme; 
            }
            cout<<"Odeme yapildi! Kalan borc: "<<odeme<<" TL\n";
            ofstream fileOdeme("Odeme.txt", ios::app);
            if(fileOdeme.is_open()){
                fileOdeme<<left<<setw(24)<<oturan_id<<setw(24)<<oturan_id/100 <<setw(24)<<fixed<<setprecision(2)<<yeniOdeme<<setw(24)<<odeme<<endl;
                fileOdeme.close();
            }
        }
    }
    void odemeDuzeltmek(){
        cout<<"Mevcut borc: "<<odeme<<endl;
        cout<<"Yeni borcu bildirin: ";
        cin>> odeme;
        while(odeme < 0){
            cout<<"Odeme para negatif olmamalidir! Tekrar deneyin..."<<endl;
            cout<<"Yeni borcu bildirin: ";
            cin>> odeme;
        }
        cout<<"Odeme duzeltildi! Mevcut borc: "<<odeme<<endl;
        ofstream fileOdeme("Odeme.txt", ios::app);
        if(fileOdeme.is_open()){
            fileOdeme<<left<<setw(24)<<oturan_id<<setw(24)<<oturan_id/100 <<setw(24)<<fixed<<setprecision(2)<<"Duzeltildi"<<setw(24)<<odeme<<endl;
            fileOdeme.close();
        }
    }
};
//Oturan sınıfından Misafir sınıfı oluşturalım.
class Misafir: public Oturan{ 

};

int main(){

    AileReisi oturan[810];
    Daire daire[9];
    int secenek;

    for(int blok = 1; blok <= 9; blok++){//Bloklari başlatmak için (9 bina olacak)
        daire[blok - 1] = Daire(blok);
    }
    ofstream fileMekan("Mekan.txt", ios::app);
    if(fileMekan.is_open()){
        fileMekan << left << setw(24) << "Daire ID" << setw(24) << "Blok" << "Durum" << endl;
        fileMekan << left << setw(24) << "--------" << setw(24) << "----" << "-----" << endl;
        fileMekan.close();
    }
    ofstream fileOdeme("Odeme.txt", ios::app);
    if(fileOdeme.is_open()){
        fileOdeme << left << setw(24) << "Daire ID" << setw(24) << "Blok" <<setw(24)<<"Odeme"<<setw(24)<<"Borc"<<endl;
        fileOdeme << left << setw(24) << "--------" << setw(24) << "----" <<setw(24)<<"-----"<<setw(24)<<"----"<<endl;
        fileOdeme.close();
    }
    ofstream fileHavuz("HavuzKul.txt", ios::app);
    if(fileHavuz.is_open()){
        fileHavuz<<"**Havuz Kullanma**\n"<<endl;
        fileHavuz<<left<< setw(39)<<"Adi Soyad"<<setw(30)<<"Daire ID"<<setw(27)<<"Blok"<<setw(27)<<"Durum"<<endl;
        fileHavuz<<left<< setw(39)<<"---------"<<setw(30)<<"--------"<<setw(27)<<"----"<<setw(27)<<"-----"<<endl;
        fileHavuz.close();
    }
    ofstream fileFitness("Fitness.txt", ios::app);
        if(fileFitness.is_open()){
            fileFitness<<"**Fitness Kullanma**\n"<<endl;
            fileFitness<<left<< setw(39)<<"Adi Soyad"<<setw(30)<<"Daire ID"<<setw(27)<<"Blok"<<setw(27)<<"Durum"<<endl;
            fileFitness<<left<< setw(39)<<"---------"<<setw(30)<<"--------"<<setw(27)<<"----"<<setw(27)<<"-----"<<endl;
            fileFitness.close();
        }

    ofstream fileData("Data.txt", ios::app);
    if(fileData.is_open()){
        fileData<<left<< setw(40)<<"Aile Reisisinin Adi"<<setw(15)<<"Daire ID"<<setw(13)<<"Blok"<<setw(15)<<"Aile Uyesi"<<endl;
        fileData<<left<< setw(40)<<"-------------------"<<setw(15)<<"--------"<<setw(13)<<"----"<<setw(15)<<"----------"<<endl;
        fileData.close();
    }

    do{
        cout<<"\n\t=== MENU ===\n\n";
        cout<<"1 - Oturan\n";
        cout<<"2 - Odeme\n";
        cout<<"3 - Havuz Kullanma\n";
        cout<<"4 - Spor Salonu Kullanma\n";
        cout<<"5 - Mekan (Daireler) raporu\n";
        cout<<"6 - Program sonlandirma\n\n";
        cout<<"Bir secenek secin: ";
        cin>>secenek;

        while(secenek < 1 || secenek > 6){
            cout<<"Secenek 1 - 6 arasinda olmalidir! Tekrar deneyin..."<<endl;
            cout<<"Bir secenek secin: ";
            cin>> secenek;
        }
        switch(secenek){
            case 1:{
                int opsyon;
                cout<<"\n\t -- DATA MENU --\n";
                cout<<"1 - Ekleme"<<endl;
                cout<<"2 - Silme"<<endl;
                cout<<"3 - Duzeltme"<<endl;
                cout<<"4 - raporlamalar \n\n";
                cout<<"Bir secenek secin: ";
                cin>>opsyon;
                while(opsyon < 1 || opsyon > 4){
                    cout<<"Secenek 1 - 4 arasinda olmalidir! Tekrar deneyin..."<<endl;
                    cout<<"Bir secenek secin: ";
                    cin>> opsyon;
                }
                switch(opsyon){
                    case 1:{
                        AileReisi yeniOturan;
                        int bloco;
                        cout<<"\nBlok sayisini girin (1 - 9): ";
                        cin>> bloco;
                        while(bloco < 1 || bloco > 9){
                        cout<<"Blok sayisini 1 - 9 arasinda olmalidir: ";
                        cin>> bloco;
                        }
                        int id = daire[bloco-1].getDaire_durum(); //Mevcut daire arama
                        if(id == 0){
                            cout<<"Kayit yapilamiyor... Bos daire yoktur.\n";
                        }else{
                            yeniOturan.ekleme(id, 1); //İkinci parametre (1) oturan üzerinde değişiklik yapmadığımızı, sadece 1 ekleyeceğimizi belirtir.
                            for (int i = 0; i < 810; i++) { // Limite de 810 para o array de oturan
                                if (oturan[i].getOturan_id() == -1) { // Verifica se a posição está vazia
                                    oturan[i] = yeniOturan;
                                  
                                    ofstream fileMekan("Mekan.txt", ios::app); //Kayıtlı daireyi dosyaya yazmak için 
                                    if(fileMekan.is_open()){
                                        fileMekan << left << setw(24) << id << setw(24) << id / 100 << "Kayitli" << endl;
                                        fileMekan.close();
                                    }
                                    break; // Interrompe o loop após adicionar
                                }
                            }
                        }
                        break;
                    }
                    
                    case 2:{
                        int id;
                        cout<<"Silinecek oturanin ID'sini girin: ";
                        cin>>id;
                        if(id < 100 || id > 999){
                            cout<<"Gecersiz ID...\n";
                            break;
                        }
                        int kontrol = id/100 - 1; // Bloğu bulmak (com base no array de 9 blocos)
                        int sonuc = daire[kontrol].daireBosalt(id); 
                        if(sonuc == 1){
                            cout<<"Daire "<<id<<" bostur\n";
                        }else if(sonuc == 0){
                            cout<<"Gecersiz ID...\n";
                        }else{
                            for(int i = 0; i < 810; i++){
                                if(oturan[i].getOturan_id() == id){
                                    oturan[i] = AileReisi();
                                    ofstream fileMekan("Mekan.txt", ios::app);
                                    if(fileMekan.is_open()){
                                        fileMekan << left << setw(24) << id << setw(24) << id / 100 << "bosaltildi" << endl;
                                        fileMekan.close();
                                    }
                                    break;
                                }
                            }
                            cout<<"Daire "<<id<<" Bosaltildi\n";
                        }
                        break;
                    }

                    case 3:{
                        int id;
                        cout<<"Duzeltilecek dairenin ID'sini girin: ";
                        cin>>id;
                        if(id < 100 || id > 999){
                            cout<<"Gecersiz ID...\n";
                            break;
                        }
                        int kontrol = id/100 - 1; //Bloğu bulmak (vektördeki pozisyon)
                        int sonuc = daire[kontrol].duzeltme(id); //ID uygun, meşgul veya geçersiz olup olmadığını kontrol edin
                        if(sonuc == 1){
                            cout<<"Daire "<<id<<" Bostur\n";
                        }else if(sonuc == 0){
                            cout<<"Gecersiz ID\n";
                        }else{
                            for(int i = 0; i < 810; i++){
                                if(oturan[i].getOturan_id() == id){
                                    cout<<"Oturan bilgilerini dogru girin...\n";
                                    oturan[i].ekleme(id, 0); //Burada sıfır (0), kayıt yapmayacağımızı, sadece düzenleme yapacağımızı belirtir
                                    ofstream fileMekan("Mekan.txt", ios::app);
                                    if(fileMekan.is_open()){
                                        fileMekan << left << setw(24) << id << setw(24) << id / 100 << "Duzeltildi" << endl;
                                        fileMekan.close();
                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    }

                    case 4:{
                        fstream fileData("data.txt", ios::in);
                        if(fileData.is_open()){
                            cout<<"\n\t\t\t        Oturanlarin Raporu"<<endl;
                            cout<<"\t\t\t       --------------------"<<endl;
                            string satir;
                            while(getline(fileData, satir)){
                                cout<<satir<<endl;
                            }
                            fileData.close();
                        }
                        break;
                    }
                }
                break;
            }

            case 2:{
                int opsyon;
                cout<<"\n\t -- ODEME MENU --\n";
                cout<<"1 - Odeme"<<endl;
                cout<<"2 - Duzeltme"<<endl;
                cout<<"3 - Raporlama"<<endl;
                cout<<"Bir secenek secin: ";
                cin>>opsyon;
                while(opsyon < 1 || opsyon > 3){
                    cout<<"Secenek 1 - 3 arasinda olmalidir! Tekrar deneyin..."<<endl;
                    cout<<"Bir secenek secin: ";
                    cin>> opsyon;
                }
                switch(opsyon){
                    case 1:{
                        int id;
                        cout<<"Odemeyi yapacak oturanin ID'sini girin: ";
                        cin>>id;
                        if(id < 100 || id > 999){
                            cout<<"Gecersiz ID...\n";
                            break;
                        }
                        int kontrol = id/100 - 1; //Bloğu bulmak 
                        int sonuc = daire[kontrol].duzeltme(id); //ID uygun, meşgul veya geçersiz olup olmadığını kontrol edin
                        if(sonuc == 1){
                            cout<<"Daire "<<id<<" bostur\n";
                        }else if(sonuc == 0){
                            cout<<"Gecersiz ID\n";
                        }else{
                            for(int i = 0; i < 810; i++){
                                if(oturan[i].getOturan_id() == id){
                                    oturan[i].odemeyapmak();
                                    break;
                                }
                            }
                        }
                        break;
                    }

                    case 2:{
                        int id;
                        cout<<"Odemeyi duzeltmek icin oturanin ID'sini girin: ";
                        cin>>id;
                        if(id < 100 || id > 999){
                            cout<<"Gecersiz ID...\n";
                            break;
                        }
                        int kontrol = id/100 - 1;  //Bloğu bulmak (vektördeki pozisyon)
                        int sonuc = daire[kontrol].duzeltme(id); //ID uygun, meşgul veya geçersiz olup olmadığını kontrol edin
                        if(sonuc == 1){
                            cout<<"Daire "<<id<<" bostur\n";
                        }else if(sonuc == 0){
                            cout<<"Gecersiz ID\n";
                        }else{
                            for(int i = 0; i < 810; i++){
                                if(oturan[i].getOturan_id() == id){
                                    oturan[i].odemeDuzeltmek();
                                    break;
                                }
                            }
                        }
                        break;
                    }
                    
                    case 3:{
                        fstream fileOdeme("Odeme.txt", ios::in);
                        if(fileOdeme.is_open()){
                            cout<<"\n\t\t\t\t   Raporlar"<<endl;
                            cout<< "\t\t\t\t  ----------"<<endl;
                            string satir;
                            while(getline(fileOdeme, satir)){
                                cout<<satir<<endl;
                            }
                            fileOdeme.close();
                        }
                        break;   
                    }
                }
                break;
            }

            case 3:{
                int opsyon;
                cout<<"1 - Oturan\n";
                cout<<"2 - Misafir \n\n";
                cout<<"Bir secenek secin: ";
                cin>>opsyon;
                while(opsyon < 1 || opsyon > 2){
                    cout<<"Secenek 1 - 2 arasinda olmalidir! Tekrar deneyin..."<<endl;
                    cout<<"Bir secenek secin: ";
                    cin>> opsyon;
                }
                string adi;
                int id;
                cout<<"Huvuz kulanacak kisinin adini girin: ";
                cin.ignore();
                getline(cin, adi);
                cout<<"Daire ID girin: ";
                cin>>id;
                if(id < 100 || id > 999){
                    cout<<"Gecersiz ID...\n";
                    break;
                }
                int blok = id/100 - 1;  //Bloğu bulmak (vektördeki pozisyon)
                int sonuc = daire[blok].duzeltme(id); //ID uygun, meşgul veya geçersiz olup olmadığını kontrol edin
                if(sonuc == 1){
                    cout<<"Daire ID "<<id<<" bostur\n";
                }else if(sonuc == 0){
                    cout<<"Gecersiz ID\n";
                }else if (opsyon == 1){// Oturan

                    for(int i = 0; i < 810; i++){
                        if(oturan[i].getOturan_id() == id){
                            sonuc = oturan[i].akrabalarBul(adi);
                            if(sonuc < 0){ 
                                cout<<"Blok: "<<id/100<<" daire "<< id<<"de kisi bulunamadi"<<endl;
                                break;
                            }else{
                                Havuz havuzNesne;
                                havuzNesne.havuzKul(adi, id, blok, sonuc);
                                break;
                            }
                        }
                    }
                }else{ //MIsafir
                    for(int i = 0; i < 810; i++){
                        if(oturan[i].getOturan_id() == id){
                            int sonuc = oturan[i].getOdeme();
                            Havuz havuzNesne;
                            havuzNesne.havuzKul(adi, id, blok, sonuc);
                            break;
                        }
                    }
                }
                break;
            }

            case 4:{
                int opsyon;
                cout<<"1 - Oturan\n";
                cout<<"2 - Misafir \n\n";
                cout<<"Bir secenek secin: ";
                cin>>opsyon;
                while(opsyon < 1 || opsyon > 2){
                    cout<<"Secenek 1 - 2 arasinda olmalidir! Tekrar deneyin..."<<endl;
                    cout<<"Bir secenek secin: ";
                    cin>> opsyon;
                }
                string adi;
                int id;
                cout<<"Spor salonunu kulanacak kisinin adini girin: ";
                cin.ignore();
                getline(cin, adi);
                cout<<"Daire ID girin: ";
                cin>>id;
                if(id < 100 || id > 999){
                    cout<<"Gecersiz ID...\n";
                    break;
                }
                int blok = id/100 - 1; //Bloğu bulmak (vektördeki pozisyon)
                int sonuc = daire[blok].duzeltme(id); //ID uygun, meşgul veya geçersiz olup olmadığını kontrol edin
                if(sonuc == 1){
                    cout<<"Daire "<<id<<" bostur\n";
                }else if(sonuc == 0){
                    cout<<"Gecersiz ID\n";
                }else if (opsyon == 1){
                    for(int i = 0; i < 810; i++){
                        if(oturan[i].getOturan_id() == id){
                            sonuc = oturan[i].akrabalarBul(adi);
                            if(sonuc < 0){ 
                                cout<<"Blok: "<<id/100<<" daire "<< id<<"de kisi bulunamadi"<<endl;
                            }else{
                                Fitness fitnesNesne;
                                fitnesNesne.sporSalonuKullanma(adi, id, blok, sonuc);
                            }
                            break;
                        }
                    }
                }else{ //Misafir
                    for(int i = 0; i < 810; i++){
                        if(oturan[i].getOturan_id() == id){
                            int sonuc = oturan[i].getOdeme();
                            Fitness fitnesNesne; 
                            fitnesNesne.sporSalonuKullanma(adi, id, blok, sonuc);
                            break;
                        }
                    }
                }
                break;
            }

            case 5:{
                fstream fileMekan("Mekan.txt", ios::in);
                if(fileMekan.is_open()){
                    cout<<"\n\t\t  Dairelerin Raporu"<<endl;
                    cout<<"\t\t  -----------------"<<endl;
                    string satir;
                    while(getline(fileMekan, satir)){
                        cout<<satir<<endl;
                    }
                    fileMekan.close();
                }
                break;
            }

            case 6:
                cout<<"Program basariyla kapatildi..."<<endl;
                break;
        }
    }while(secenek != 6);

    return 0;
}