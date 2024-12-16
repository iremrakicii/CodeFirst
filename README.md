# CodeFirst Projesi

Bu proje, Entity Framework Core kullanarak "Code-First" yaklaşımıyla oluşturulmuş bir veritabanı modelini içermektedir. Projede iki ana entity bulunmaktadır: **Game** (Oyun) ve **Movie** (Film). Bu iki entity arasında çoktan çoğa bir ilişki kurulmuştur.

## Proje İçeriği

### Entity'ler
1. **Game (Oyun)**
   - `Id`: Benzersiz bir kimlik numarası (int).
   - `Name`: Oyunun adı (string) **[Zorunlu]**.
   - `Platform`: Oyunun çalıştığı platform (string).
   - `Rating`: Oyunun derecelendirmesi (decimal).
   - `Movies`: Bu oyunla ilişkili filmlerin listesi.

2. **Movie (Film)**
   - `Id`: Benzersiz bir kimlik numarası (int).
   - `Title`: Filmin başlığı (string) **[Zorunlu]**.
   - `Genre`: Filmin türü (string).
   - `ReleaseYear`: Filmin çıkış yılı (int).
   - `Games`: Bu filmle ilişkili oyunların listesi.

### Veritabanı Bağlantısı
Veritabanı bağlantısı, `PatikaFirstDbContext` sınıfı aracılığıyla yapılandırılmıştır. 

#### Bağlantı Dizesi
`OnConfiguring` metodu içinde kullanılan bağlantı dizesi:
```csharp
optionsBuilder.UseSqlServer("Server=LAKICI53;Database=PatikaCodeFirstDb1;Trusted_Connection=True;TrustServerCertificate=True;");
```

### Tablolar
Veritabanında aşağıdaki tablolar oluşturulacaktır:

**Movies**: Filmler için tablo.
**Games**: Oyunlar için tablo.

## OnModelCreating
OnModelCreating metodu içinde her iki entity'nin tablolarla eşleştirilmesi yapılmıştır:
```
modelBuilder.Entity<Movie>().ToTable("Movies");
modelBuilder.Entity<Game>().ToTable("Games");
```

