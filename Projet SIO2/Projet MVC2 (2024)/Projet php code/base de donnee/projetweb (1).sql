-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 23 avr. 2024 à 07:38
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `projetweb`
--

-- --------------------------------------------------------

--
-- Structure de la table `activites`
--

DROP TABLE IF EXISTS `activites`;
CREATE TABLE IF NOT EXISTS `activites` (
  `Id_Activites` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `datee` date DEFAULT NULL,
  `lieu` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Activites`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `activites`
--

INSERT INTO `activites` (`Id_Activites`, `nom`, `datee`, `lieu`) VALUES
(1, 'Conference Doliprane', '2024-04-15', 'chez salim'),
(2, 'Tennis', '2024-04-15', 'Parc XYZ');

-- --------------------------------------------------------

--
-- Structure de la table `effets_secondaires`
--

DROP TABLE IF EXISTS `effets_secondaires`;
CREATE TABLE IF NOT EXISTS `effets_secondaires` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_medicament` int(11) DEFAULT NULL,
  `effet` varchar(255) DEFAULT NULL,
  `description` text,
  `type` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_medicament` (`id_medicament`)
) ENGINE=MyISAM AUTO_INCREMENT=40 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `effets_secondaires`
--

INSERT INTO `effets_secondaires` (`id`, `id_medicament`, `effet`, `description`, `type`) VALUES
(1, 1, 'Reaction allergique', 'Possibilite de reaction allergique', 'secondaire'),
(2, 2, 'Irritation gastrique', 'Peut causer une irritation de l\'estomac', 'secondaire'),
(3, 3, 'Troubles gastro-intestinaux', 'Peut provoquer des troubles gastro-intestinaux', 'secondaire'),
(4, 4, 'Effets thyrotoxiques', 'Possibilite d\'hyperthyroidie', 'secondaire'),
(5, 5, 'Constipation', 'Risque de constipation', 'secondaire'),
(6, 6, 'Hemorragies', 'Risque accru de saignements', 'secondaire'),
(7, 7, 'Somnolence', 'Possibilite de somnolence', 'secondaire'),
(8, 8, 'Reaction allergique', 'Possibilite de reaction allergique', 'secondaire'),
(35, 13, 'Diarrhee', 'Peut causer des selles molles ou liquides', 'secondaire'),
(34, 13, 'Nausees', 'Peut provoquer des nausees chez certains patients', 'secondaire'),
(33, 12, 'Augmentation de la pression arterielle', 'Peut augmenter la pression arterielle chez certains patients', 'secondaire'),
(32, 12, 'Irritation gastrique', 'Peut causer une irritation de l\'estomac', 'secondaire'),
(31, 11, 'Somnolence', 'Peut entrainer de la somnolence chez certains patients', 'secondaire'),
(30, 11, 'Secheresse buccale', 'Peut causer une sensation de secheresse dans la bouche', 'secondaire'),
(29, 10, 'Nausees', 'Peut provoquer des nausees chez certains patients', 'secondaire'),
(28, 10, 'Maux de tete', 'Peut causer des maux de tete chez certains patients', 'secondaire'),
(27, 9, 'Troubles gastro-intestinaux', 'Peut provoquer des troubles gastro-intestinaux', 'secondaire'),
(26, 9, 'Irritation gastrique', 'Peut causer une irritation de l\'estomac', 'secondaire'),
(25, 8, 'Troubles gastro-intestinaux', 'Peut provoquer des troubles gastro-intestinaux', 'secondaire'),
(24, 8, 'Reaction allergique', 'Possibilite de reaction allergique', 'secondaire'),
(36, 14, 'Somnolence', 'Peut provoquer de la somnolence ou de la fatigue', 'secondaire'),
(37, 14, 'Dependance', 'Peut causer une dependance physique et psychologique', 'secondaire'),
(38, 15, 'Douleurs musculaires', 'Peut causer des douleurs musculaires ou de la faiblesse', 'secondaire'),
(39, 15, 'Problemes hepatiques', 'Peut entrainer des anomalies des tests hepatiques', 'secondaire');

-- --------------------------------------------------------

--
-- Structure de la table `effets_therapeutiques`
--

DROP TABLE IF EXISTS `effets_therapeutiques`;
CREATE TABLE IF NOT EXISTS `effets_therapeutiques` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_medicament` int(11) DEFAULT NULL,
  `effet` varchar(255) DEFAULT NULL,
  `description` text,
  `type` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_medicament` (`id_medicament`)
) ENGINE=MyISAM AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `effets_therapeutiques`
--

INSERT INTO `effets_therapeutiques` (`id`, `id_medicament`, `effet`, `description`, `type`) VALUES
(1, 1, 'Reduction de la fievre', 'Diminue la temperature corporelle', 'therapeutique'),
(2, 2, 'Analgesie', 'Reduit la douleur', 'therapeutique'),
(3, 3, 'Anti-inflammatoire', 'Reduit l\'inflammation', 'therapeutique'),
(4, 4, 'Thyroide', 'Regule la fonction thyroidienne', 'therapeutique'),
(5, 5, 'Antidiarrheique', 'Ralentit le transit intestinal', 'therapeutique'),
(6, 6, 'Anticoagulant', 'Diminue la coagulation sanguine', 'therapeutique'),
(7, 7, 'Antispasmodique', 'Relache les muscles lisses de l\'appareil digestif', 'therapeutique'),
(8, 8, 'Reduction de la fievre', 'Diminue la temperature corporelle', 'therapeutique'),
(37, 13, 'Traitement des infections bacteriennes', 'Aide a guerir les infections causees par des bacteries', 'therapeutique'),
(36, 13, 'Antibiotique', 'Tue les bacteries et traite les infections', 'therapeutique'),
(35, 12, 'Soulagement de la douleur', 'Diminue la douleur musculaire et articulaire', 'therapeutique'),
(34, 12, 'Anti-inflammatoire', 'Reduit l\'inflammation dans le corps', 'therapeutique'),
(33, 11, 'Reduction des symptomes allergiques', 'Soulage les eternuements, les demangeaisons et le nez qui coule', 'therapeutique'),
(32, 11, 'Antihistaminique', 'Bloque les effets de l\'histamine dans le corps', 'therapeutique'),
(31, 10, 'Traitement des ulceres gastro-duodenaux', 'Aide a guerir les ulceres de l\'estomac et du duodenum', 'therapeutique'),
(30, 10, 'Reduction de l\'acidite gastrique', 'Diminue la production d\'acide gastrique', 'therapeutique'),
(29, 9, 'Anti-inflammatoire', 'Reduit l\'inflammation', 'therapeutique'),
(28, 9, 'Analgesie', 'Reduit la douleur', 'therapeutique'),
(27, 9, 'Reduction de la fievre', 'Diminue la temperature corporelle', 'therapeutique'),
(26, 8, 'Analgesie', 'Reduit la douleur', 'therapeutique'),
(25, 8, 'Reduction de la fievre', 'Diminue la temperature corporelle', 'therapeutique'),
(38, 14, 'Anxiolytique', 'Reduit l\'anxiete et la tension', 'therapeutique'),
(39, 14, 'Sedatif', 'Calme et detend le systeme nerveux', 'therapeutique'),
(40, 15, 'Reduction du cholesterol', 'Diminue le taux de cholesterol dans le sang', 'therapeutique'),
(41, 15, 'Prevention des maladies cardiovasculaires', 'Reduit le risque de maladies cardiaques', 'therapeutique');

-- --------------------------------------------------------

--
-- Structure de la table `effet_secondaire`
--

DROP TABLE IF EXISTS `effet_secondaire`;
CREATE TABLE IF NOT EXISTS `effet_secondaire` (
  `Id_Medicaments` int(11) NOT NULL,
  `Id_Effets_Secondaires` int(11) NOT NULL,
  PRIMARY KEY (`Id_Medicaments`,`Id_Effets_Secondaires`),
  KEY `Id_Effets_Secondaires` (`Id_Effets_Secondaires`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `effet_therapeutique`
--

DROP TABLE IF EXISTS `effet_therapeutique`;
CREATE TABLE IF NOT EXISTS `effet_therapeutique` (
  `Id_Medicaments` int(11) NOT NULL,
  `Id_Effets_Therapeutiques` int(11) NOT NULL,
  PRIMARY KEY (`Id_Medicaments`,`Id_Effets_Therapeutiques`),
  KEY `Id_Effets_Therapeutiques` (`Id_Effets_Therapeutiques`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

DROP TABLE IF EXISTS `inscription`;
CREATE TABLE IF NOT EXISTS `inscription` (
  `Id_Utilisateurs` int(11) NOT NULL,
  `Id_Activites` int(11) NOT NULL,
  PRIMARY KEY (`Id_Utilisateurs`,`Id_Activites`),
  KEY `Id_Activites` (`Id_Activites`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `inscription`
--

INSERT INTO `inscription` (`Id_Utilisateurs`, `Id_Activites`) VALUES
(1, 1),
(1, 2),
(34, 1),
(34, 2),
(35, 1),
(36, 2),
(37, 1),
(37, 2),
(38, 1),
(40, 1),
(41, 1),
(41, 2);

-- --------------------------------------------------------

--
-- Structure de la table `interaction`
--

DROP TABLE IF EXISTS `interaction`;
CREATE TABLE IF NOT EXISTS `interaction` (
  `Id_Medicaments` int(11) NOT NULL,
  `Id_Medicaments_1` int(11) NOT NULL,
  PRIMARY KEY (`Id_Medicaments`,`Id_Medicaments_1`),
  KEY `Id_Medicaments_1` (`Id_Medicaments_1`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `medicaments`
--

DROP TABLE IF EXISTS `medicaments`;
CREATE TABLE IF NOT EXISTS `medicaments` (
  `Id_Medicaments` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`Id_Medicaments`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `medicaments`
--

INSERT INTO `medicaments` (`Id_Medicaments`, `nom`, `description`) VALUES
(1, 'Doliprane', 'Maux de tete'),
(2, 'Efferalgan', 'Efferalgan est un medicament a base de paracetamol, similaire au Dafalgan, utilise pour soulager la douleur et abaisser la fievre.'),
(3, 'DAFALGAN', ' Le dafalgan est utilise pour soulager la douleur et reduire la fievre.'),
(4, 'LEVOTHYROX', 'Le Levothyrox est un medicament pour l\'hypothyroidie, contenant de la levothyroxine, regulant le metabolisme.'),
(5, 'IMODIUM', 'Imodium est un medicament antidiarrheique utilise pour traiter les troubles gastro-intestinaux, en ralentissant les mouvements de l\'intestin pour reduire la diarrhee.\r\n\r\n\r\n\r\n\r\n\r\n'),
(6, 'KARDEGIC', 'Le Kardegic est un medicament contenant de l\'aspirine, utilise pour prevenir les caillots sanguins et les maladies cardiovasculaires en reduisant l\'agregation plaquettaire.\r\n\r\n\r\n\r\n\r\n\r\n'),
(7, 'SPASFON', 'Spasfon est un medicament antispasmodique utilise pour soulager les douleurs abdominales causees par les spasmes musculaires, notamment les crampes intestinales et menstruelles.\r\n\r\n\r\n\r\n\r\n\r\n'),
(8, 'Paracetamol', 'Antipyretique et analgesique couramment utilise pour traiter la fievre et la douleur'),
(9, 'Ibuprofene', 'Anti-inflammatoire non steroidien utilise pour soulager la douleur et reduire l\'inflammation'),
(10, 'Omeprazole', 'Inhibiteur de la pompe a protons utilise pour traiter les brulures d\'estomac et les ulceres gastro-duodenaux'),
(11, 'Loratadine', 'Antihistaminique utilise pour traiter les symptomes allergiques tels que les eternuements, les demangeaisons et le nez qui coule'),
(12, 'Naproxene', 'Anti-inflammatoire non steroidien utilise pour soulager la douleur et reduire l\'inflammation'),
(13, 'Amoxicilline', 'Antibiotique utilise pour traiter diverses infections bacteriennes'),
(14, 'Diazepam', 'Anxiolytique et sedatif utilise pour traiter l\'anxiete, les spasmes musculaires et l\'epilepsie'),
(15, 'Atorvastatine', 'Inhibiteur de la HMG-CoA reductase utilise pour reduire le cholesterol et prevenir les maladies cardiovasculaires');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `Id_Utilisateurs` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `profession` varchar(50) DEFAULT NULL,
  `e_mail` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Utilisateurs`)
) ENGINE=MyISAM AUTO_INCREMENT=44 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`Id_Utilisateurs`, `nom`, `prenom`, `profession`, `e_mail`) VALUES
(42, 'ismail', 'ismail', 'sephora', 'Salim.82assou@gmail.com'),
(41, 'moahamed', 'boura', 'footballer', 'footballer@gmail.com'),
(40, 'naruto', 'mraxane', 'sephora', 'naelle@gmail.com'),
(39, 'ismail', 'ourici', 'airbus', 'ismail.ouribi@gmail.com'),
(38, 'ismail', 'gdhdh', 'agora', 'naelle@gmail.com'),
(37, 'naruto', 'ismail', 'chomeur', 'Salim.82assou@gmail.com'),
(36, 'assou', 'sofiane', 'livreur ', 'sofiane@gmail.com'),
(35, 'aaaa', 'gdhdh', 'sephora', 'Salim.82assou@gmail.com'),
(34, 'naruto', 'ismail', 'airbus', 'argent2@volant.com'),
(33, 'ismail', 'ourici', 'airbus', 'ismail.ouribi@gmail.com'),
(43, 'ismail', 'ourici', 'sephora', 'ismail.ouribi@gmail.com');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
