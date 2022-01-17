SELECT CB.Id, CB.nom, CB.prenom, CB.telephone, c.solde, c.taux, c.coutOperation 
FROM compte AS C 
INNER JOIN clientCompte AS CC ON C.Id = CC.IdCompte
INNER JOIN clientBanque AS CB ON CC.IdClient = CB.Id
WHERE CC.IdCompte = 4;