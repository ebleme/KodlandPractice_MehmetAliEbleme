# KodlandPractice_MehmetAliEbleme
 


Hatalar:

 Solution oluşmuyordu 
	- external tool için gerekli package yükledim. Benim için package managerdan Rider paketini Unity e ekledim ve solution u oluşturdum
 Unity UI paketi olmadığından UI componentleri Unity de eklenemiyordu. Ayrıca kod tarafında UI componentlerine erişim mümkün değildi. 
	- UnityUI paketini projeye ekledim

 Proje klasör yapısı düzenlendi.
 Sahne gameobject lerin düzeni değiştirildi
 Oyun başlatıldığında PlayerController yok oluyordu
	- Start metodundaki Destroy(this); satırını sildim	
 Oyun başlar başlamaz Game Over Paneli aktif oluyordu
	- ChangeHealth(100); methodunu bu şekilde yapınca sorun çözüldü.

 Player sahneye model olarak eklenmiş. Bunun yerine ayrı bir gameobject altında Prefab olarak yapılması daha mantıklı
 Player hareket etmiyordu
	- PlayerMovement Scriptini ekledim
	- GroundCheck gameobject i ve Terrain layer ı ekledim
 Player rotasyon yapmıyordu
	- MouseSense parametresini arttırdım. örnek olarak 5 yaptım
 Bullet ateş etmiyordu. 
	- Bulletı prefab ı PlayerController a atadım
	- Bullet Instantiate 
	- speed+=1f; satırını sildim çünkü bullet ın ilerleme hızını sürekli arttırmaktan başka bir işe yaramıyordu.
	- transform.position += direction * speed * Time.deltaTime; satırında "Time.deltaTime" yerine "Time.fixedDeltaTime" kullandım.
	- Bullet a lifeTime ekledim. Belirli bir süre sonra bullet yok olacak. Bu sayede hiç bir yere çarpmayan bullet ın sonsuza kadar sahnede kalmasına engel oldum.
	
 Karakter animasyonları yoktu
	- Mixamo'ya modeli yükledim "idle aim" ve "walking aim" animasyonlarını indirdim
	- AnimationController oluşturdum ve animasyonları ekledim
	
 Enemy ler model olarak sahneye eklenmiş.
	- Ayrı bir gameobject altında Prefab yapıldı
	- Enemy lere collider eklendi ve tag ları "Enemy" olarak atandı.
	- EnemyController eklendi. Enemy lere atış kabiliyeti verildi
 Camera standart player içine eklenmiş cameraydı
	- Projeye Cinemachine paketi eklendi
	- Sahneye Cinemachine Virtual Camera eklendi
	- Sonrasında player ı  follow etmesi sağlandı


