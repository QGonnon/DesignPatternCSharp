using System;

public class FabriqueDocumentProfessionnel : FabriqueDocument
{
    public override Releve CreerReleve()
    {
        return new ReleveProfessionnel();
    }

    public override Attestation CreerAttestation()
    {
        return new AttestationProfessionnel();
    }
}