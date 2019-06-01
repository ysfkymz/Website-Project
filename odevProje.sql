create database stajProjesi


use stajProjesi




create table staj(
	kurum_adi varchar(100),
	ad varchar(100),
	soyad varchar(100),
	gun int,
	sehir varchar(50),
	bas_tarihi date,
	bit_tarihi date,
	toplam_gun int,
	staj_konu varchar(100),
	ogr_sinif int,
	kabul_gun int,
	durum bit,
	ogr_no int,
	primary key(ogr_no,bas_tarihi),
	foreign key(staj_konu) references konu(staj_konu) on delete cascade,
);

select * from staj

create table konu(
	staj_konu varchar(100) primary key,
);


create table komisyon(
	id int  primary key,
	unvan varchar(50),
	ad varchar(100),
	soyad varchar(100),
);

create table mulakat(
	ogr_no int,
	bas_tarihi date,
	tarih date,
	saat time,
	komisyon1 int,
	komisyon2 int,
	devam int default 0,
	caba int default 0,
	is_vaktinde_yapma int default 0,
	amire_davranis int default 0,
	ekibe_davranis int default 0,
	proje int default 0,
	duzen int default 0,
	sunum int default 0,
	icerik int default 0,
	mulakat int default 0,
	primary key(ogr_no,bas_tarihi),
	foreign key(ogr_no,bas_tarihi) references staj(ogr_no,bas_tarihi) on delete cascade,
	foreign key(komisyon1) references komisyon(id) on delete cascade,
	foreign key(komisyon2) references komisyon(id) on delete cascade,
	
	
);

select * from mulakat







