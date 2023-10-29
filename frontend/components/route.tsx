"use client";
import Link from "next/link";
import { usePathname } from "next/navigation";

export type NavLink = {
  label: string;
  href: string;
};
type Props = {
  navLinks: NavLink[];
};

const Route = ({ navLinks }: Props) => {
  const pathname = usePathname();

  return (
    <>
      {navLinks.map((link) => {
        const isActive = pathname === link.href;

        return (
          <Link
            key={link.label}
            href={link.href}
            className={isActive ? "active" : ""}
          >
            {link.label}
          </Link>
        );
      })}
    </>
  );
};

export { Route };