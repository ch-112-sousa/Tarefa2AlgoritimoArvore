select 
	  t2.Departamento
	, t2.Pessoa
	, t2.Salario
from
(
	select
			  d.Id as dId
			, p.DeptId
			, MAX(p.salario) as MaxSalario
	from Departamento d
	inner join pessoa p
		on d.Id = p.DeptId
	group by d.Id, p.DeptId

) t1
inner join 
(
	select
			   p.id as pId
			,  d.Id as dId
			, p.Nome as Pessoa
			, d.Nome as Departamento
			, p.DeptId
			, p.Salario
	from Departamento d
	inner join pessoa p
		on d.Id = p.DeptId
) t2 
on  t1.dId = t2.dId
where t1.MaxSalario = t2.Salario





















