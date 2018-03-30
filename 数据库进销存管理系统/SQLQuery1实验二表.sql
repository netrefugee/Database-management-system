create table t_bm(
bh char(2) not null constraint PK_t_bm primary key,
mc varchar(10) not null,
fzrbh char(4) not null,
bmbh char(2)not null)

create table t_zy(
bh char(4) not null constraint PK_t_zy primary key,
mc varchar(10) not null)

create table t_zg(
bh char(4) not null constraint PK_t_zg primary key,
xm varchar(8) not null,
xb char(2),
csrq datetime,
zybh char(4),
hf bit,
bmbh char(2),
kl varchar(10) constraint DF_t_zg_kl default 000000,
qx tinyint not null constraint DF_t_zg_qx default 2,
constraint FK_t_zg_t_bm foreign key(bmbh) references t_bm(bh),
foreign key(zybh) references t_zy(bh))

alter table t_bm add constraint FK_t_bm_t_zg foreign key(fzrbh) references t_zg(bh)

alter table t_zg drop constraint FK_t_zg_t_bm
alter table t_zg add constraint Fk_t_zg_t_bm foreign key(bmbh) references t_bm(bh)

create table t_khgys(
bh varchar(10)not null,
mc varchar(20)not null,
lxr varchar(8)not null,
lxdh varchar(12)not null,
primary key(bh))

create table t_jhd(
jhrq datetime not null,
xh smallint not null,
primary key(jhrq,xh),
gysbh varchar(10) not null references t_khgys(bh),
jhrbh char(4) not null references t_zg(bh))

create table t_sp(
bh varchar(10)not null,
mc varchar(20)not null,
xh varchar(16)not null,
gg varchar(16),
dw varchar(2)not null,
kcxx smallint,
kcsx smallint,
constraint CK_t_sp_kcx check(kcxx>=0 and kcxx<kcsx),
primary key(bh))

create table t_jhmx(
jhrq datetime not null,
xh smallint not null,
spbh varchar(10) not null,
primary key(jhrq,xh,spbh),
sl smallint not null constraint CK_t_jhmx_sl check(sl>0),
dj decimal(12,2) not null constraint CK_t_jhmx_dj check(dj>0),
foreign key(jhrq,xh) references t_jhd(jhrq,xh),
foreign key(spbh) references t_sp(bh))

create table t_xsd(
xsrq datetime not null,
xh smallint not null,
khbh varchar(10) not null,
xsrbh char(4) not null,
primary key(xsrq,xh),
foreign key (khbh) references t_khgys(bh),
foreign key (xsrbh) references t_zg(bh))

create table t_xsmx(
xsrq datetime not null,
xh smallint not null,
spbh varchar(10) not null,
sl smallint not null constraint CK_t_xsmx_sl check(sl>0),
dj decimal(12,2) not null constraint CK_t_xsmx_dj check(dj>0),
primary key(xsrq,xh,spbh),
foreign key(xsrq,xh) references t_xsd(xsrq,xh),
foreign key(spbh) references t_sp(bh))

create table t_kc(
spbh varchar(10) not null,
sl smallint not null constraint CK_t_kc_sl check(sl>0),
dj decimal(12,2)constraint CK_t_kc_dj check(dj>0),
primary key(spbh),
foreign key (spbh) references t_sp(bh))

create table t_cs(
mc varchar(10)not null,
nr varchar(20),
primary key(mc))



insert into t_zy values('1001','市场营销')
insert into t_zy values('1002','物流管理')
insert into t_zy values('1101','信息管理')
insert into t_zy values('1201','会计学')
insert into t_zy values('1301','电子商务')
insert into t_zg values('1001','张丰水','男','19700101','1201','0','11','000000','')
insert into t_bm values('11','技术部','1001')

