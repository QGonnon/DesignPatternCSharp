using System;

public class FabriqueDocumentParticulier : FabriqueDocument
{
    public override Releve CreerReleve()
    {
        return new ReleveParticulier();
    }

    public override Attestation CreerAttestation()
    {
        return new AttestationParticulier();
    }
}