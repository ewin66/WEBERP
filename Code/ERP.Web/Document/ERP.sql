

--�ͻ���
create table base_customer
(
	id int identity(1,1) primary key,
	jc_name nvarchar(200) not null default(''),--�ͻ����
	name nvarchar(200) not null default(''),--�ͻ�����
	contacts nvarchar(100) not null default(''),--�ͻ���ϵ��
	contacts_phone nvarchar(100) not null default(''),--�ͻ���ϵ�˵绰
	email nvarchar(100),--����
	grade nvarchar(20),--�ͻ��ȼ�
	address nvarchar(200) not null default(''),--�ͻ���ַ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--��Ӧ�̱�
create table base_supplier
(
	id int identity(1,1) primary key,
	jc_name nvarchar(200) not null default(''),--��Ӧ�̼��
	name nvarchar(200) not null default(''),--��Ӧ������
	contacts nvarchar(100) not null default(''),--��Ӧ����ϵ��
	contacts_phone nvarchar(100) not null default(''),--��Ӧ����ϵ�˵绰
	email nvarchar(100),--����
	grade nvarchar(20),--��Ӧ�̵ȼ�
	address nvarchar(200) not null default(''),--��Ӧ�̵�ַ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--�������ݱ�
create table base_data
(
	id int identity(1,1) primary key not null,--����
	name nvarchar(100) not null default(''),---����
	type nvarchar(20) not null default(0),--����
	remark nvarchar(300),--��ע˵��
	isenable bit not null default(0),--�Ƿ����
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--��Ʒ��
create table base_product
(
	id int identity(1,1) primary key,
	name nvarchar(200) not null default(''),--��Ʒ����
	type nvarchar(20),--��Ʒ����1 ��Ʒ,2���Ʒ
	guige nvarchar(200),--���
	unit nvarchar(20) not null,--��λ
	price decimal(10,4) not null default(0),--��Ʒ����
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--������Ϣ��
create table base_parts
(
	id int identity(1,1) primary key not null,--id
	name varchar(50) not null default(''),--����name
	type nvarchar(20),--��������
	guige nvarchar(200),--���
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(500),--��ע
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--�������ձ�
create table base_technology
(
	id int identity(1,1) primary key not null,--id
	parts_id int not null,--����id
	name varchar(50) not null default(''),--��������
	orderby int not null,
	remark nvarchar(max),--����Ҫ��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--����
create table base_process
(
	id int identity(1,1) primary key not null,--id
	name varchar(50) not null default(''),--��������
	type nvarchar(20),--�������� 1,������,2,��������
	guige nvarchar(200),--���
	unit varchar(50) not null default(''),--��λ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(1000),--����Ҫ��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--���ϱ�
create table base_material
(
	id int identity(1,1) primary key,
	name nvarchar(50) not null default(''),--��������
	type nvarchar(20) not null,--���Ϸ���
	unit varchar(10) not null default(''),--��λ
	price decimal(10,4) not null default(0),--�ɹ�����
	guige nvarchar(200),--���
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--�ֿ�
create table base_warehouse
(
	id int identity(1,1) primary key not null,--����
	name nvarchar(100) not null default(''),--��������
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--����
create table base_area
(
	id int identity(1,1) primary key not null,--����
	name nvarchar(100) not null default(''),--��������
	warehouse_id int not null,--�����ֿ�
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--����
create table base_location
(
	id int identity(1,1) primary key not null,--����
	name nvarchar(100) not null default(''),--��������
	warehouse_id int not null,--�����ֿ�
	wname nvarchar(50),
	area_id int not null,--��������
	aname nvarchar(50),
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--�����
create table base_workshop
(
	id int identity(1,1) primary key not null,--����
	name nvarchar(100) not null default(''),--��������
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--ʩ������
create table erp_construction
(
	id int identity(1,1) not null,--����
	no nvarchar(100) not null primary key,--TO00001
	product_id int not null,--��Ʒ���
	product_name nvarchar(100) not null,--��Ʒ����
	customer_no nvarchar(100) not null,--�ͻ����
	customer_name nvarchar(100) not null,--�ͻ�����
	number int not null,--����
	practical_number int,--ʵ����������
	loss_number int,--�������
	guige nvarchar(100) not null,--���
	zhuangdinfa nvarchar(100) not null,--װ����
	baozhuangfa nvarchar(100) not null,--��װ��
	address nvarchar(200) not null,--�ջ���ַ
	delivery_date date not null,--��������
	source_no nvarchar(100),--Դ���ݱ��
	state int not null,--״̬ 0��ȷ�� --1�ƻ���,2������,3�����
	affirm_time datetime,--ȷ��ʱ��
	affirm_username nvarchar(40),--ȷ���û�
	finish_time datetime,--���ʱ��
	finish_username nvarchar(40),--����û�
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)


--ʩ����������
create table erp_parts
(
	id uniqueidentifier primary key not null,
	con_no nvarchar(50) not null,--ʩ�������
	parts_id int not null,--�������
	parts_name nvarchar(100) not null,--��������
	parts_guige nvarchar(100) not null,--�������
	number int not null,--��������
	state int not null,--״̬ 0��ȷ�� --1������,2������,3�����
	remarrk nvarchar(max),--��ע
)

--�������������
create table erp_process
(
	id uniqueidentifier primary key not null,
	con_no nvarchar(200) not null,--ʩ�������
	erp_parts_id uniqueidentifier not null,--��������
	process_id int not null,--������
	process_name nvarchar(100) not null,--�������� 
	sort int not null,--�����
	number int not null,--�ƻ���������
	is_waifa bit not null default(0),--�Ƿ��ⷢ
	unit nvarchar(20) not null,--��λ
	panel nvarchar(100),--�����Ϣ
	remarrk nvarchar(max),--����Ҫ��
)

--�������ϱ�
create table erp_material
(
	id int identity(1,1) not null,--����
	con_no nvarchar(100) not null,--ʩ�������
	erp_parts_id uniqueidentifier not null,--��������
	material_no nvarchar(50) not null,--���ϱ��
	material_name nvarchar(100) not null,--�������
	is_waifadailiao bit not null default(0),--�Ƿ����ⷢ����
	number int,--��������
	unit nvarchar(20) not null,--��λ
	remarrk nvarchar(max),--��ע
)

create table erp_workorder
(
	id int identity(1,1) not null,--����
	no nvarchar(50) primary key not null,--������MO0001
	con_no nvarchar(50) not null,--ʩ�������
	product_name nvarchar(50) not null,--��Ʒ����
	delivery_date date not null,--��������
	erp_parts_id uniqueidentifier not null,--��������ID
	parts_id int not null,--����ID
	parts_name nvarchar(50) not null,--��������
	erp_process_id uniqueidentifier not null,--���򵥾�ID
	process_id int not null,--����ID
	process_name nvarchar(50) not null,--��������
	panel nvarchar(100),--�����Ϣ
	number int not null,--��������
	practical_number int,--����������
	loss_number int,--�ۼ��������
	unit nvarchar(20) not null,--��λ
	workshop_id int,--�Ų���������ID
	workshop_name nvarchar(50),--��������
	remarrk nvarchar(max),--������ע+����ע
	state int not null,--״̬ 0���Ų�,1,������,2������,3�����
	arrange_username nvarchar(40),--������
	arrange_time datetime,--�Ų�ʱ��
	complete_username nvarchar(40),--�깤ȷ����
	complete_time datetime,--�깤ʱ��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)

--����������
create table erp_workorder_produce
(
	id int identity(1,1) not null,--����
	workorder_no nvarchar(50) not null,
	product_name nvarchar(50) not null,--��Ʒ����
	parts_name nvarchar(50) not null,--��������
	process_name nvarchar(50) not null,--��������
	number int not null,--��������
	produce_number int not null,--��������
	warehouse_id int,--�ֿ�
	warehouse_name nvarchar(50),--�ֿ�
	area_id int,--����
	area_name nvarchar(50),--����
	location_id int,--����λ��
	location_name int,--����λ��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)


--�ⷢ����
create table erp_outsource
(
	id int identity(1,1) not null,--����
	no nvarchar(100) not null default('') primary key,--WO00001
	source_no nvarchar(50),--Դ���ݱ��
	supplier_id int not null,--��Ӧ�̱��
	supplier_name int not null,--��Ӧ������
	delivery_date date not null,--��������
	parts_id int not null,--����ID
	parts_name nvarchar(50) not null,--��������
	process_id int not null,--����ID
	process_name nvarchar(50) not null,--��������
	number int not null,--��������
	price decimal(10,4) not null,--�ɹ�����
	account decimal(10,2) not null,--�ܽ��
	unit nvarchar(20) not null,--��λ
	remarrk nvarchar(max),--������ע+����ע
	state int not null,--״̬ 0��ȷ��,1,��ȷ��,2���;
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)

--�ɹ�������
create table erp_purchase
(
	id int identity(1,1) not null,--����
	no nvarchar(100) not null default('') primary key,--PO00001
	source_no nvarchar(50),--Դ���ݱ��
	type int not null,--�ɹ����� 1�����ɹ� 2�칫�ɹ� 3
	supplier_id int not null,--��Ӧ�̱��
	supplier_name int not null,--��Ӧ������
	delivery_date date not null,--��������
	parts_id int not null,--����ID
	parts_name nvarchar(50) not null,--��������
	process_id int not null,--����ID
	process_name nvarchar(50) not null,--��������
	number int not null,--��������
	price decimal(10,4) not null,--�ɹ�����
	account decimal(10,2) not null,--�ܽ��
	unit nvarchar(20) not null,--��λ
	remarrk nvarchar(max),--������ע+����ע
	state int not null,--״̬ 0��ȷ��,1,��ȷ��,2���;
	arrange_username nvarchar(40),--������
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)

--�ɹ�����
create table erp_purchase_detail
(
	id int identity(1,1) not null,--����
	erp_purchase_no varchar(50) not null,--�����¼
)

--��ⵥ��
create table erp_storage
(
	id int identity(1,1) not null,--����
	no nvarchar(100) not null default('') primary key,--HO00001
	source_no nvarchar(50) not null,--Դ����
	type int not null,--����1��Ʒ 2�ⷢ 3�ɹ�
	in_no int not null,--ID
	in_name nvarchar(100) not null,--�������
	number int not null,--�������
	unit nvarchar(20) not null,--��λ
	warehouse_id int not null,--�ֿ�id
	warehouse_name nvarchar(100) not null,--�ֿ�name
	aera_id int not null,--�ֿ�-����ID
	aera_name nvarchar(100) not null,--�ֿ�-��������
	location_id int not null,--��Ӧ����id
	location_name int not null,--��Ӧ����
	state int not null,--״̬ 0��ȷ��,1,��ȷ��,2���;
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)

--����
create table erp_inventory
(
	id int identity(1,1) not null,--����
	type int not null,--����1��Ʒ 2���� 3����
	in_no int not null,--ID
	in_name nvarchar(100) not null,--��Ʒ����
	number int not null,--����
	create_time datetime not null default(getdate()),--ʱ��
	create_username nvarchar(40) not null,--�����û�
)




