
import Link from "next/link";
import Image from "next/image";

export default function Sidebar() {
    return (
        <>
            <div className="menu">

                <div className="botaoMenu">
                    <div className="menuIcon">
                        <Image
                            width={24}
                            height={24}
                            loading="lazy"
                            src="/imgs/icons/svg/menu.svg"
                            alt="Menu"
                        />
                    </div>
                </div>

                <Link href="/clients" className="menuItemBullet">
                    <div className="menuIcon">
                        <Image
                            width={24}
                            height={24}
                            loading="lazy"
                            src="/imgs/icons/svg/clients.svg"
                            alt="Clientes"
                        />
                    </div>
                    <div className="menuTexto">Clientes</div>
                </Link>

                <Link href="/vehicles" className="menuItemBullet">
                    <div className="menuIcon">
                        <Image
                            width={24}
                            height={24}
                            loading="lazy"
                            src="/imgs/icons/svg/car.svg"
                            alt="Veiculos"
                        />

                    </div>
                    <div className="menuTexto">Veiculos</div>
                </Link>

                <Link href="/allocation" className="menuItemBullet">
                    <div className="menuIcon">
                        <Image
                            width={24}
                            height={24}
                            loading="lazy"
                            src="/imgs/icons/svg/allocation.svg"
                            alt="Locação"
                        />

                    </div>
                    <div className="menuTexto">Locação</div>
                </Link>


            </div>
        </>
    )
}
