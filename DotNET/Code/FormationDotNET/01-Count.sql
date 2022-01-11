-- La fonction Count() permet de compter le nombre de lignes en correspondance avec nos critères
SELECT Emp.* 
FROM EMPLOYEE Emp

-- Compter le nombre de lignes dans notre table
SELECT Count(Emp.EMP_ID) AS Nb_Employes
FROM EMPLOYEE Emp

-- Affichage de la table ACCOUNT
SELECT * FROM ACCOUNT

-- Requête permentant de compter le nombre de client ayant au moin un compte dans l'agence
SELECT Count( DISTINCT Acc.CUST_ID ) AS ClientDistinct
FROM ACCOUNT Acc

-- Lister les client et leur compte (par Id Client)
SELECT Acc.Cust_ID,
		Count(Acc.ACCOUNT_ID) As NbComptes
FROM Account Acc
Group By Acc.CUST_ID