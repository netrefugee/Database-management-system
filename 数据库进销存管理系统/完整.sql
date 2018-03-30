create table t_bm(
bh char(2) not null constraint PK_t_bm primary key,
mc varchar(10) not null,
fzrbh char(4) not null)

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

alter table t_zg drop constraint FK_t_zg_t_bm

insert into t_zy values('1001','市场营销')
insert into t_zy values('1002','物流管理')
insert into t_zy values('1101','信息管理')
insert into t_zy values('1201','会计学')
insert into t_zy values('1301','电子商务')
insert into t_zg values('1001','张丰水','男','19700101','1201','0','11','000000','')
insert into t_bm values('11','技术部','1001')

alter table t_zg add constraint Fk_t_zg_t_bm foreign key(bmbh) references t_bm(bh)

create view v_jhdje as
select jhrq,xh,sum(sl*dj) as je from t_jhmx group by jhrq,xh

create view v_sp as
select a.*,b.sl,b.dj from t_sp a left outer join t_kc b on a.bh=b.spbh

create function BuildBhFromDateAndXh(@Date datetime,@Num int,@Length int=4)
returns varchar(14) as
begin
	declare @s char(10)
	set @s = convert(char(10),@Date,102)
	return left(@s,4)+substring(@s,6,2)+right(@s,2)+dbo.BuildLeadingZeroStr(@Num,@Length)
end

create view v_jhd as
select a.jhrq,a.xh,a.gysbh,b.mc as gysmc,a.jhrbh,c.xm as jhrxm,d.je,bh=dbo.BuildBhFromDateAndXh(a.jhrq,a.xh,default)
from t_jhd a
	left join t_khgys b on a.gysbh = b.bh
	left join t_zg c on a.jhrbh = c.bh
	left join v_jhdje d on a.jhrq = d.jhrq and a.xh = d.xh
	
insert into t_khgys
values('000001','客户A','神秘人A','000000001')
insert into t_khgys
values('000002','客户B','神秘人B','000000002')
insert into t_khgys
values('000003','客户C','神秘人C','000000001')

insert into t_sp
values('0001','炸弹','A001','10','个','0','5000')
insert into t_sp
values('0002','炸弹','A002','20','个','0','5000')
insert into t_sp
values('0003','炸弹包','B001','40','个','0','5000')

insert into t_jhd
values('20171109','0001','000001','1001')
insert into t_jhd
values('20171110','0002','000001','1001')
insert into t_jhd
values('20171111','0003','000002','1001')

insert into t_jhmx
values('20171109','0001','0001','5000','20')
insert into t_jhmx
values('20171110','0002','0001','5000','20')
insert into t_jhmx
values('20171111','0003','0002','5000','30')

create procedure p_insjhd
@gysbh varchar(10),@jhrbh char(4),@jhrq datetime output,@xh int output as
set @jhrq = CONVERT(datetime, CONVERT(char(10),getdate(),101))
set @xh = (select MAX(xh) from t_jhd where jhrq=@jhrq)
if @xh is null set @xh=0
set @xh = @xh+1
insert into t_jhd(jhrq,xh,gysbh,jhrbh)values(@jhrq,@xh,@gysbh,@jhrbh)

create procedure p_rk
@jhrqtmp datetime,@xhtmp int as
declare @spbh varchar(10),@sl smallint,@dj decimal(12,2)
declare jhmxtmp cursor for
select spbh,sl,dj from t_jhmx where jhrq=@jhrqtmp and xh= @xhtmp order by spbh
open jhmxtmp
begin transaction
fetch next from jhmxtmp into @spbh,@sl,@dj
declare @error_var int,@rowcount_var int
while @@FETCH_STATUS=0
begin
update t_kc set dj=(sl*dj+@sl*@dj)/(sl+@sl),sl=sl+@sl where spbh = @spbh
select @error_var=@@ERROR,@rowcount_var=@@ROWCOUNT
if @error_var<>0
begin
raiserror('更新库存错误',16,1)
goto error_handler
end
if @rowcount_var=0
begin
insert into t_kc(spbh,sl,dj)values(@spbh,@sl,@dj)
if @@error<>0
begin
raiserror('插入库存商品错误',16,1)
goto error_handler
end
end
fetch next from jhmxtmp into @spbh,@sl,@dj
end
close jhmxtmp
deallocate jhmxtmp
commit transaction
return 0
error_handler:
close jhmxtmp
deallocate jhmxtmp
rollback transaction
return 1